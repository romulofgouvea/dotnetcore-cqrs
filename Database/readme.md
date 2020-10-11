# Banco de dados

## Criando um ambiente com docker do banco de dados

Abra o terminal e insira o comando abaixo para criar um banco de dados com *MySQL* rodando no docker:

> *Você pode alterar a variavel *MYSQL_ROOT_PASSWORD*, lembre-se de guarda-la para seguir o proximo passo

```bash
docker run -p 3306:3306 --name mysql -e MYSQL_ROOT_PASSWORD=postgres -d mysql:latest
```

## Acessando via DBeaver

 - Na barra de ferramentas clicar `Database` > `New Database Connection`;
 - Selecionar na lateral a opção `all` e buscar na barra de pesquisa por MySQL 8+ e selecionar ele;
 - Adicionar o Server host, port, username e passsword de acordo com os dados inseridos no comando do docker, por padrao no dbeaver o host é localhost, port é 3306 e username é root e a senha que será digitada é a definida no comando anterior *MYSQL_ROOT_PASSWORD*;

### Erros
Caso tenha os erros apontados: 
- [Public Key Retrieval is not allowed]
  - Clicar no botão `Edit Driver Settings` e entrar na panel `Connection properties` e adicionar 2 propriedades: *useSSL* com valor false e *allowPublicKeyRetrieval* com valor true 



# Iniciando o banco de dados
Para iniciar o banco de dados abra o Dbeaver clique na conexão criada pelo passo anterior e depois selecione na barra de ferramentas `SQL Editor` > `New SQL Editor` copie o conteúdo do arquivo `1.sql` cole no editor do Dbeaver e execute, ao final do script executado, confira se o banco de nome `cqrs` e a tabela de nome `candidate` foi criado na panel `Databases` dentro da conexão.