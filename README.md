# Projeto de Tradu��o com Cache e Medi��o de Tempo

## Descri��o

Este projeto implementa um sistema de tradu��o baseado em arquivos XML, utilizando **cache de tradu��es** para otimizar o desempenho e **medir o tempo de execu��o** de cada opera��o de tradu��o com a classe `Stopwatch`. O objetivo � evitar a leitura repetida dos arquivos XML e fornecer uma forma de monitorar o tempo de execu��o das tradu��es.

---

## Funcionalidades

- **Cache de Tradu��es**: Utiliza o `ConcurrentDictionary` para armazenar as tradu��es carregadas em mem�ria, evitando a necessidade de ler os arquivos XML repetidamente.
- **Medi��o de Tempo**: A fun��o `MeasureExecutionTime` utiliza a classe `Stopwatch` para medir o tempo de execu��o de cada tradu��o, mostrando os resultados no console.
- **Leitura de Arquivo XML**: Carrega os arquivos XML de tradu��o a partir de um diret�rio espec�fico e realiza a busca pela chave desejada.

---

## Estrutura do C�digo

### 1. **Classe `Program`**

A classe `Program` � respons�vel por medir o tempo de execu��o de cada chamada ao m�todo `ServiceTranslation.T`.
