# Desafio Técnico - Backend

API para um quadro Kanban com endpoints para login de usuário, consulta, adição, edição e remoção de cards.

## Rodando o Projeto

### Clonando o repositório
- Executar o comando: 
```console
> git clone https://github.com/cmsulzbeck/KanbanAPI.git
```

### Navegando para a pasta do Backend
- Abrir a pasta do projeto no Visual Studio Code
- Executar o comando no terminal do Visual Studio Code:
```console
> cd .\BACK\
```

### Setando configurações e variáveis de ambiente
- Criar os seguintes arquivos no diretório BACK, respectivamente, esses arquivos não subiram para o git, por conter informações sensíveis (nome e senha do usuário e segredo usado para gerar o JWT)
  - appsettings.json
  - appsettings.Development.json
-  Copiar os conteúdos dos arquivos de exemplo (appsettingsExemplo.txt e appsettingsExemplo.Development.txt) para os arquivos appsettings.json e appsettings.Development.json, respectivamente
- Setar os valores das variáveis de ambiente com os seguintes valores:
  - "User": "letscode"
  - "Senha": Lets@123"
  - "Segredo":  812420036f1fbb7f5f5b8bf96d3c3a245c508c8f3b6fff1b40b5afbfc113422a945f06ce609be9dc513db9d8fe62a5e03370e3142a2d5a85c1d2e452998c8c55
- OBS 1: A senha contém um caráctere em upper case, como parte de uma restrição usada no exemplo para gerar a lógica de login do Backend
- OBS 2: O segredo foi gerado usando um comando JavaScript para gerar uma cadeia de carácteres aleatória, pode ser qualquer valor semelhante, não entendi muito bem como deveria ser feito essa requisição das variáveis de ambiente, por isso essa parte pode estar errada

### Configurando banco de dados SQLite
- Executar os seguintes comandos no terminal do Visual Studio Code
```console
> dotnet ef migrations script
> dotnet ef database update
```
- O primeiro comando serve para verificar se as configurações do banco de dados estão corretas, já que as migrações subiram para o git junto com o projeto, o segundo comando serve para garantir que o banco de dados esteja atualizado para consulta
- Foi usada a extensão do SQLite para realizar consultas no banco de dados e testar se os endpoints estavam funcionando corretamente
- Caso não os comando mencionados acima não funcionem, execute os comando abaixo no terminal do Visual Studio Code:
```console
> dotnet ef migrations script
> dotnet ef migrations add <nome_da_migração>
> dotnet ef database update
```
- O campo <nome_da_migração> deve ser substituído pelo nome da preferência do Usuário

### Rodando a API
- Abrir o terminal do Visual Studio Code
- Digitar o seguinte comando:
```console
> dotnet watch run
```
- O comando acima deve abrir automaticamente o index.html da aplicação. que é a documentação Swagger da API, nessa página podem ser examinados os endpoints da API. como especificado no gitlabs
- É necessário fazer a requisição de login antes de fazer qualquer outra, tentar fazer antes, resultará em um código de erro 401 - Unauthorized

## Tecnologias Usadas
- IDE: Visual Studio Code
- Banco de dados: SQLite
- Teste de requisições: Postman

## Dificuldades
- A principal dificuldade que enfrentei nesse projeto foi a adição de um dockerfile, a qual não consegui terminar a tempo. Ao testar a imagem gerada pelo Dockerfile, não estava sendo possível acessar o servidor gerado para testar os endpoints dentro do container Docker

## Contatos
- Caso não esteja sendo possível rodar o projeto, seguem meus contatos e o link para o meu github, para que eu possa esclarecer quaisquer dúvidas:
  - [Repositório do Projeto](https://github.com/cmsulzbeck/KanbanAPI).
  - [Meu GitHub](https://github.com/cmsulzbeck).
  - Meu email: cmsulzbeck@hotmail.com
  - Telefone: (11)99995-4037
