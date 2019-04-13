# MyGameScore

Aplicativo Web desenvolvido com Angular e REST API, para registrar e obter estatísticas das partidas disputados em uma temporada.

## Configurações do Aplicativo

### Banco de Dados

* Execute os dois scripts dentro da pasta Scripts, primeiro o arquivo 'Database.sql' depois 'TableMatch.sql'.

### REST API

* Abra o arquivo 'MyGameScore.sln' dentro da pasta MyGameScore.

* Altere a porta utilizada pela API nas propriedades do projeto 'MyGameScore' dentro da pasta 1-Services.

* Altere a connection string presente no arquivo 'appsettings.Development.json' no mesmo projeto, colocando a connection string do banco que você acabou de criar.

### Angular

* Abra o editor de texto de sua preferência na pasta WebApp.

* Altere a porta utilizada pelo aplicativo na pasta:

```
WebApp\src\environments\environment.ts
```

* Baixe as dependências do projeto executando o seguinte comando no terminal:

```
npm i
```

### Execute os projetos

* Execute a API selecionando o projeto MyGameScore como o projeto de inicialização.

* Por fim, rode a aplicação do Angular executando seguinte o comando no terminal:

```
ng serve --open
```