
# Sistema de Gestão de Colaboradores e Unidades

Este é um projeto de backend implementado em C# que oferece um Sistema de Gestão de Colaboradores e Unidades, utilizando o PostgreSQL com banco de dados.

## Configuração do Ambiente de Desenvolvimento:

- Certifique-se de ter o .NET Core SDK instalado na sua máquina.
- Instale o PostgreSQL e configure um banco de dados com as credenciais apropriadas.

**Configuração do Banco de Dados:**

- Neste repositório haverá a pasta "Infraestrutura" localizando o arquivo "ConectionContext.cs", a classe ConectionContext contém a configuração do Entity Framework Core para acessar o banco de dados PostgreSQL. As informações de conexão estão definidas no método OnConfiguring. Por favor altere os parametros de acordo com seu PostgreSQL.

**Configuração do Projeto:** 

Abra o projeto no Visual Studio ou utilizando o CLI do .NET Core

 Execute o seguinte comando para remover arquivos temporários e binários:
```bash
dotnet clean
```
 Execute o seguinte comando para compilar o projeto, isso deve instalar todas as dependências necessárias:
```bash
dotnet build
```
Execute o seguinte comando para adicionar uma nova migração ao contexto do banco de dados, isso cria uma nova migração no projeto para refletir as alterações feitas no modelo de banco de dados:
```bash
dotnet ef migrations add nome_migracao
```
Execute o seguinte comando para aplicar as migrações pendentes ao banco de dados, isso aplica as migrações pendentes ao banco de dados especificado na configuração.:
```bash
dotnet ef database update
```
Após o procedimento poderá executar a API no topo do ambiente do Visual Studio

