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
