# Neemias Borges - SI_GerenciamentoClientProdutos
Teste Prático para Desenvolvedor Pleno C#, Windows Forms e PostgreSQL

# Documentação do Sistema

## Casos de Uso 

#### Gerenciamento de Clientes
- **Cadastrar Cliente**: Permite a inclusão de novos clientes com as seguintes informações: nome, endereço, telefone e email.
- **Editar Cliente**: Permite a modificação das informações de clientes já cadastrados.
- **Remover Cliente**: Permite a exclusão de clientes do sistema.
- **Listar Clientes**: Permite o sistema de listar todos os clientes ja criados

#### Gerenciamento de Produtos
- **Cadastrar Produto**: Permite a inclusão de novos produtos com as seguintes informações: nome, descrição, preço e estoque.
- **Editar Produto**: Permite a modificação das informações de produtos já cadastrados.
- **Remover Produto**: Permite a exclusão de produtos do sistema.
- **Listar Produtor**: Permite o sistema de listar todos os produtos criados pelo usuario

#### Realização de Vendas
- **Registrar Venda**: Permite a realização de vendas registrando o cliente, os produtos e a quantidade, preço de cada item vendido.
- ** Listar Vendas**: Permite listar todas as vendas ja feitas pelo usuario

### Relatórios
- **Relatório de Vendas**: Gera um relatório detalhando a venda realizada, incluindo informações sobre o cliente,produto,preço e quantidade total no documento.


## Requisitos Técnicos e Linguagens utilizads

- **Linguagem de Programação**: C#
- **Interface Gráfica**: Windows Forms com MetroSet_UI
- **Banco de Dados**: PostgreSQL versão 16.3-2
- **Driver de Conexão com PostgreSQL**: NPGSQL 8.03
- **Ferramenta de Relatórios**: ReportViewer RDLC 17.0.0
- **Arquitetura escolhida**: Clean Architecture
- **Testes**: MSTest e Moq para testes
- **Logging e Alertas**: SEQ

## Estrutura do Projeto e Pastas

Abaixo está a estrutura de pastas do projeto, organizada de acordo com a minha interpretação da Clean Architecture:

```
/src
│
├── /Dominio
│   ├── /Entidades
├── /Aplicacao
│   ├── /DTO
│   ├── /Interfaces
│   ├── /Services
├── /Repositorio
│   ├── /Exceptions
│   ├── /Infra
│   └── /Interfaces
├── /View
│   ├── /Views
│   └── /Forms
│   ├── /Scripts
│   ├── /Content
│   ├── /Database
│   ├── /Fonts
│   ├── /Relatorios/
│   ├───── /PedidoVenda
└── /Infraestrutura
    ├── /Configuracoes
    ├── /Logging
    └── /Integracoes
```

### 1. Configuração do Ambiente

1. Instale o [PostgreSQL](https://www.postgresql.org/docs/current/release-16-3.html) versão 16

2. Instale e configure o [SEQ](https://datalust.co/seq) para logging e alertas
   ![image](https://github.com/NeemiasBorges/SI_GerenciamentoClientProdutos/assets/51499704/2a444ea4-b8a9-4ea6-8fbb-c4067729b2f1)

### 2. Conexão com o Banco de Dados
A conexão com o banco de dados PostgreSQL é realizada através do NPGSQL. Para fazer a conexao com o banco de dados, devemos configurar a String de Conexao no arquivo App.config localizado na camada View
Deve se alterar a tag PorstgresConnection


#### 3. Configuração do SEQ (Opcional)
Caso deseje configurar tambem o Seq, basta no mesmo arquiv App.config alterar a key Serilog:SeqUrl
 
### 4. Configurando o Banco de Dados
Execute os scripts SQL fornecidos na pasta raiz com o nome de `scriptsSQL` para criar as tabelas necessárias no PostgreSQL.

No momento de configurar o projeto e criar o script, adicionei alguns registros previos nas tabelas para facilitar a primeira utilização do sistema



### 5. Testes
Os testes unitários e de integração são realizados na camada de Tests importando os objetos da camada de Applicação (DTO) e os de Modelagem na camada Dominio (Entidade)
Para executar os testes basta Clicar com o botão direito na camada e selecionar ‘Executar Testes’


### 6. Executando o Sistema
Abra o projeto no Visual Studio, configure a string de conexão no código e execute o projeto. A interface gráfica será exibida, permitindo a utilização das funcionalidades descritas acima.

#### Clientes
- Cadastro/Edição/Exclusão
![clienteGIF](https://github.com/NeemiasBorges/SI_GerenciamentoClientProdutos/assets/51499704/b7a3facf-43e9-46fa-a350-83539c5e4d05)

#### Produtos
- Cadatro/Edição/Exclusão/Listar
![produto](https://github.com/NeemiasBorges/SI_GerenciamentoClientProdutos/assets/51499704/cb4f53cc-6a82-4d33-9a84-3550f4dc78c2)
  
#### Vendas
- Cadatro/Edição/Listar
![vendas](https://github.com/NeemiasBorges/SI_GerenciamentoClientProdutos/assets/51499704/99d7a6d3-4b97-4124-80ce-7f2fd6a2f11c)

### Relatórios
![relatorio](https://github.com/NeemiasBorges/SI_GerenciamentoClientProdutos/assets/51499704/be133622-234b-4ca5-a8e6-61b98505338a)


## Contato
+55 11 96292-6357


