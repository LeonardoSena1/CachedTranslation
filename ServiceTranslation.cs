using System.Collections.Concurrent;
using System.Xml.Linq;
using TranslationBasedXml.Models;

namespace TranslationBasedXml
{
    public static class ServiceTranslation
    {
        private static readonly ConcurrentDictionary<string, XElement> XmlCache = new();

        public static string T(TranslationEnum translationEnum, string Text)
        {
            XElement xml = XmlCache.GetOrAdd(translationEnum.ToString(),
                enumValue =>
                {
                    var PathXml = LoadPathTranslation(translationEnum);
                    return XElement.Load(PathXml);
                });

            string value = xml.Descendants("text")
                        .Where(x => (string)x.Attribute("name") == Text)
                        .Select(x => x.Value)
                        .FirstOrDefault();

            return value ?? Text;
        }


        public static string LoadPathTranslation(TranslationEnum translationEnum)
        {
            var language = Path.Combine(Directory.GetCurrentDirectory(), "LocalizationTranslation");

            if (!Directory.Exists(language))
                throw new DirectoryNotFoundException($"Diretório de traduções não encontrado: {language}");

            string[] xmlFiles = Directory.GetFiles(language, "*.xml");

            string path = xmlFiles.FirstOrDefault(e => e.ToLower().Contains(translationEnum.ToString().ToLower()));

            if (string.IsNullOrEmpty(path))
                throw new FileNotFoundException($"Arquivo de tradução para '{translationEnum}' não encontrado no diretório: {language}");

            return path;
        }
    }
}
