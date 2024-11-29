# Projeto de Tradução com Cache e Medição de Tempo

## Descrição

Este projeto implementa um sistema de tradução baseado em arquivos XML, utilizando **cache de traduções** para otimizar o desempenho e **medir o tempo de execução** de cada operação de tradução com a classe `Stopwatch`. O objetivo é evitar a leitura repetida dos arquivos XML e fornecer uma forma de monitorar o tempo de execução das traduções.

---

## Funcionalidades

- **Cache de Traduções**: Utiliza o `ConcurrentDictionary` para armazenar as traduções carregadas em memória, evitando a necessidade de ler os arquivos XML repetidamente.
- **Medição de Tempo**: A função `MeasureExecutionTime` utiliza a classe `Stopwatch` para medir o tempo de execução de cada tradução, mostrando os resultados no console.
- **Leitura de Arquivo XML**: Carrega os arquivos XML de tradução a partir de um diretório específico e realiza a busca pela chave desejada.

---

## Estrutura do Código

### 1. **Classe `Program`**

A classe `Program` é responsável por medir o tempo de execução de cada chamada ao método `ServiceTranslation.T`.

### 2. **Como usar**

1. Defina os arquivos de tradução XML: Os arquivos XML de tradução devem ser colocados no diretório LocalizationTranslation no diretório atual do projeto.

2. Chame o método ServiceTranslation.T: Para obter uma tradução, chame o método ServiceTranslation.T, passando o idioma e a chave do texto que deseja traduzir.

```csharp
var translation = ServiceTranslation.T(TranslationEnum.pt_BR, "Text");
Console.WriteLine(translation); // Exibe a tradução do "Text"
```

3. Medir o tempo de execução: Para medir o tempo de execução de cada tradução, utilize o método MeasureExecutionTime, que irá medir e exibir o tempo no console.
