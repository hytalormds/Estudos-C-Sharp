# Exercicios C#

Repositorio de estudos em C# e .NET, organizado por branches para separar conteudos de fundamentos, APIs e ASP.NET MVC. O objetivo e registrar a evolucao dos exercicios, exemplos de aula e projetos praticos.

## Branches avaliadas

| Branch | Conteudo | Observacoes |
| --- | --- | --- |
| `main` | Exercicios de console em C# | Mesma base da branch `Basico`; inclui fundamentos, POO, colecoes, LINQ, tratamento de erros, vetores e matrizes. |
| `Basico` | Exercicios basicos e intermediarios | Aponta para o mesmo commit de `main` e `origin/Basico`. |
| `API's` | Projetos de Web API | Contem a API `ApiCatalogo` com Entity Framework Core, MySQL, Repository Pattern, Unit of Work, DTOs, AutoMapper, filtros, logs, Swagger, paginacao, ordenacao e filtros. A branch local esta 3 commits a frente de `origin/API's`. |
| `MVC` | Projeto ASP.NET Core MVC | Contem o projeto `MVC_2026`, com catalogo de lanches, categorias, views Razor, repositories, migrations, SQL Server e inicio do carrinho de compras. |

## Conteudo da branch `main` / `Basico`

A branch principal concentra exercicios de console separados por assunto:

- Entrada, processamento e saida
- Estruturas de selecao e condicionais
- Estruturas de repeticao
- Funcoes e metodos
- Vetores e matrizes
- Try/Catch
- Programacao orientada a objetos
- Estruturas de dados e LINQ
- List, Dictionary, HashSet, Queue e Stack

Os exercicios estao organizados em pastas com projetos `.csproj`, solucoes `.sln` ou `.slnx` e arquivos `Program.cs`.

## Conteudo da branch `API's`

A branch `API's` concentra estudos de ASP.NET Core Web API no diretorio `API/`.

Principais pontos implementados:

- Projeto `ApiCatalogo` em .NET 8
- Controllers para `Categorias` e `Produtos`
- Entity Framework Core com MySQL via Pomelo
- Migrations e populacao inicial de dados
- Repository Pattern generico
- Unit of Work
- DTOs e AutoMapper
- JSON Patch para atualizacao parcial de produtos
- Filtros de excecao e logging customizado
- Swagger/OpenAPI
- Paginacao com metadados no header `X-Pagination`
- Filtros por nome de categoria e preco de produto

Caminho principal:

```text
API/ApiCatalogo/ApiCatalogo.slnx
API/ApiCatalogo/ApiCatalogo/ApiCatalogo.csproj
```

Banco configurado no projeto:

```text
Server=localhost;Database=CatalogoDb;Uid=root;Pwd=;
```

## Conteudo da branch `MVC`

A branch `MVC` concentra estudos de ASP.NET Core MVC no diretorio `MVC_2026/`.

Principais pontos implementados:

- Projeto ASP.NET Core MVC em .NET 8
- Models de `Categoria`, `Lanche` e `CarrinhoCompraItem`
- Controllers `HomeController` e `LancheController`
- Views Razor para home, lista de lanches e componentes compartilhados
- Repositories para categorias e lanches
- Entity Framework Core com SQL Server
- Migrations e seed inicial com `DbInitializer`
- Arquivos estaticos em `wwwroot`
- Inicio do fluxo de carrinho de compras

Caminho principal:

```text
MVC_2026/MVC_2026.slnx
MVC_2026/MVC_2026/MVC_2026.csproj
```

Banco configurado no projeto:

```text
Server=localhost;Database=Lanches;Trusted_Connection=True;TrustServerCertificate=True
```

## Requisitos

- Git
- .NET SDK 8 ou superior
- Visual Studio 2022 ou Visual Studio Code
- MySQL para executar a branch `API's`
- SQL Server ou SQL Server Express/LocalDB para executar a branch `MVC`

Alguns exercicios da branch `main` usam `net10.0`; para esses projetos, use uma SDK compativel com a versao indicada no `.csproj` ou ajuste o `TargetFramework` conforme o ambiente de estudo.

## Como navegar pelas branches

Liste as branches disponiveis:

```bash
git branch --all
```

Acesse os exercicios basicos:

```bash
git checkout main
```

Acesse os estudos de API:

```bash
git checkout "API's"
```

Acesse o projeto MVC:

```bash
git checkout MVC
```

## Como executar exercicios de console

Entre na pasta do exercicio desejado e execute:

```bash
dotnet run
```

Exemplo:

```bash
cd "Estrutura de Dados e LINQ/Ex1/Ex1"
dotnet run
```

## Como executar a API

Troque para a branch da API:

```bash
git checkout "API's"
```

Entre no projeto principal:

```bash
cd "API/ApiCatalogo/ApiCatalogo"
```

Restaure dependencias, aplique migrations e execute:

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Com o ambiente em desenvolvimento, a documentacao Swagger fica disponivel na URL exibida pelo `dotnet run`, normalmente em `/swagger`.

## Como executar o MVC

Troque para a branch MVC:

```bash
git checkout MVC
```

Entre no projeto principal:

```bash
cd "MVC_2026/MVC_2026"
```

Restaure dependencias, aplique migrations e execute:

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Abra a URL exibida no terminal para acessar a aplicacao web.

## Observacoes importantes

- O repositorio possui arquivos gerados e de ambiente versionados, como `bin/`, `obj/` e `.vs/` em varias pastas.
- Para evolucao do projeto, e recomendado adicionar ou revisar um `.gitignore` para projetos .NET.
- Antes de executar API ou MVC, revise as connection strings em `appsettings.json` de acordo com o banco instalado localmente.
- A branch `API's` local possui commits que ainda nao estao no remoto.
