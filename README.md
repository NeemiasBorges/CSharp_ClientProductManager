# Neemias Borges - SI_GerenciamentoClientProdutos
Teste Prático para Desenvolvedor Pleno C#, Windows Forms e PostgreSQL

# Documentação do Sistema

## Visão Geral

## Casos de Uso 

### Gerenciamento de Clientes
- **Cadastrar Cliente**: Permite a inclusão de novos clientes com as seguintes informações: nome, endereço, telefone e email.
- **Editar Cliente**: Permite a modificação das informações de clientes já cadastrados.
- **Remover Cliente**: Permite a exclusão de clientes do sistema.

### Gerenciamento de Produtos
- **Cadastrar Produto**: Permite a inclusão de novos produtos com as seguintes informações: nome, descrição, preço e estoque.
- **Editar Produto**: Permite a modificação das informações de produtos já cadastrados.
- **Remover Produto**: Permite a exclusão de produtos do sistema.

### Realização de Vendas
- **Registrar Venda**: Permite a realização de vendas registrando o cliente, os produtos e a quantidade de cada item vendido.

### Relatórios
- **Relatório de Vendas**: Gera relatórios detalhados das vendas realizadas, incluindo informações sobre clientes e produtos.
- **Relatório de Clientes**: Gera relatórios com informações detalhadas sobre os clientes cadastrados no sistema.
- **Relatório de Estoque**: Gera relatórios sobre o estoque de produtos, ajudando na gestão e reposição de itens.

## Requisitos Técnicos e Linguagens utilizads

- **Linguagem de Programação**: C#
- **Interface Gráfica**: Windows Forms com MetroSet_UI
- **Banco de Dados**: PostgreSQL versão 13
- **Driver de Conexão com PostgreSQL**: NPGSQL
- **Controle de Versão**: Git
- **Ferramenta de Relatórios**: ReportViewer
- **Arquitetura**: Clean Architecture
- **Testes**: Camada de testes (com dados mockados - teste)
- **Logging e Alertas**: SEQ

## Estrutura do Projeto

### Estrutura de Pastas

Abaixo está a estrutura de pastas do projeto, organizada de acordo com a Clean Architecture:

```
/src
│
├── /Entidades
│   ├── /DTOs
│   ├── /Interfaces
│   ├── /Commum
│   └── /Util
│
├── /Aplicacao
│   ├── /DTO
│   ├── /Interfaces
│   ├── /Services
│   ├── /Log
│   └── /Exceptions
│
├── /Repositorio
│   ├── /DTOs
│   ├── /Repositorio
│   └── /Interfaces
│
├── /View
│   ├── /Views
│   └── /Forms
│
└── /Infraestrutura
    ├── /Configuracoes
    ├── /Logging
    └── /Integracoes
```

### 1. Configuração do Ambiente
1. Instale o [PostgreSQL](https://www.postgresql.org/) versão 13
2. Instale e configure o [SEQ](https://datalust.co/seq) para logging e alertas
   
### 2. Conexão com o Banco de Dados
A conexão com o banco de dados PostgreSQL é realizada através do NPGSQL. Abaixo está um exemplo de como configurar a conexão no arquivo de configuração do projeto.

#### Exemplo de Conexão
```csharp
using Npgsql;

string connectionString = "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=sua_base_de_dados";
using (var connection = new NpgsqlConnection(connectionString))
{
    connection.Open();
    // Sua lógica de banco de dados aqui
}
```
#### Configuração do SEQ (Opcional)
```csharp
using Serilog;
using Serilog.Sinks.Seq;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Seq("http://localhost:5341")
    .CreateLogger();
```

### 3. Testes
Os testes unitários e de integração são realizados utilizando dados mockados para garantir a confiabilidade do sistema.

#### Exemplo de Teste Unitário
```csharp
using Xunit;

public class ClienteTests
{
    [Fact]
    public void TestarCadastroDeCliente()
    {
        // Código de teste para cadastro de cliente
    }
}
```

### Configurando o Banco de Dados
Execute os scripts SQL fornecidos na pasta `/scripts` para criar as tabelas necessárias no PostgreSQL.

### Executando o Sistema
Abra o projeto no Visual Studio, configure a string de conexão no código e execute o projeto. A interface gráfica será exibida, permitindo a utilização das funcionalidades descritas acima.

## Contato
+55 11 96292-6357
