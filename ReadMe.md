# Trilha .NET Squadra

# Projeto de Implementação de CRUD de Médicos

## Tecnologia utilizada 

- DotNet Core 5
- Projeto WebApi

## Escopo
	Projeto de manipulação de cadastro de médicos 

## Persistencia

- PostgreSql versão 13.2.1 
	-  Banco de dados - BancoClinica


## Utilização do Projeto
	1. Após fazer o clone do projeto, utilizar o comando no pompt de comando na pasta do projeto 
		- dotnet restore
	2. Para criação do banco de dados 
		- dotnet ef database update

	
##Lista dos EndPoints
	1. Web Api com endpoints utilizando https://localhost:5001
	2. Documentação da api para listar os EndPoints - https://localhost:5001/swagger
	
###Lista geral de EndPoints
	1. /api/medico - Lista todos os Médicos - utilizando requisição Get
	2. /api/medico - Adiciona um Novo Médico - utilizando requisição Post
	3. /api/medico/id - Lista um Médico por Id - utilizando requisição Get
	4. /api/medico/id - Apaga um Médico por Id - utilizando requisição Delete
	5. /api/medico/id - Altera um Médico por Id - utilizando requisição Put

	* Onde id é o parametro passado com o código do médico








