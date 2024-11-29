

using System.Diagnostics;
using TranslationBasedXml;

public class Program
{
    public static void Main(string[] args)
    {
        var TranslationText = MeasureExecutionTime(() =>
            ServiceTranslation.T(TranslationBasedXml.Models.TranslationEnum.pt_BR, "Text"),
            "Text");

        var TranslationText1 = MeasureExecutionTime(() =>
            ServiceTranslation.T(TranslationBasedXml.Models.TranslationEnum.pt_BR, "language"),
            "language");

        var TranslationText3 = MeasureExecutionTime(() =>
            ServiceTranslation.T(TranslationBasedXml.Models.TranslationEnum.pt_BR, "Translator"),
            "Translator");
    }

    public static string MeasureExecutionTime(Func<string> action, string keyName)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        var result = action();
        stopwatch.Stop();
        Console.WriteLine($"Tempo para '{keyName}': {stopwatch.ElapsedMilliseconds}ms");
        return result;
    }
}