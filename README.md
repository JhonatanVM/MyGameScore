# MyGameScore

Aplicativo Web desenvolvido com Angular e REST API, para registrar e obter estat�sticas das partidas disputados em uma temporada.

##Configura��es do Aplicativo

###Banco de Dados

Execute os dois scripts dentro da pasta Scripts, primeiro o arquivo 'Database.sql' depois 'TableMatch.sql'.

###REST API

Abra o arquivo 'MyGameScore.sln' dentro da pasta MyGameScore.
Altere a porta utilizada pela API nas propriedades do projeto 'MyGameScore' dentro da pasta 1-Services.
Altere a connection string presente no arquivo 'appsettings.Development.json' no mesmo projeto, colocando a connection string do banco que voc� acabou de criar.

###Angular

Abra o editor de texto de sua prefer�ncia na pasta WebApp.
Altere a porta utilizada pelo aplicativo na pasta:

```
WebApp\src\environment\environment.ts
```

Baixe as depend�ncias do projeto executando o seguinte comando no terminal:

```
npm-i
```

###Execute os projetos

Execute a API selecionando o projeto MyGameScore como o projeto de inicializa��o.

Por fim, rode a aplica��o do Angular executando seguinte o comando no terminal:

```
ng serve --open
```