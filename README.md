# graphQL
pratice dotnet an graphql
### Tag: v2.0_UpdateEFWithCommand-Migration
1. Update Entity
    * Add Command class in Models.cs
    * Add List Command in Platform
2. Update DbContext
    1. override OnModelCreating in AppDbContext in Data.cs
    2. run command to migrate with DB
        ```
        dotnet ef migrations add AddCommandToDb
        ```
    3. run command to update in Database
        ```
        dotnet ef database update
        ```
3. Add UseProjection anotation into Query in GraphQL.cs
4. AddProjections service into ConfigureServices in Startup.cs


### Tag: v1.6_AddGraphQLVoyager-ParallelQueries
1. add GraphQLVoyager from method Configure in Startup.cs
    * type on browser: http://localhost:5000/graphql-voyager/
2. parallel queries 
    * (replace AddDbContext to AddPooledDbContextFactory) in Startup.cs
    * add UseDbContext in Query class at GraphQL.cs
    * Replace Service to ScopedService in Query class at GraphQL.cs
    ![query parallel](https://raw.githubusercontent.com/baodainguyen/graphQL/master/imgs/queryParallel.png)


### Tag: v1.5_MockDb-RunProject
1. Create fake Data in Database (use InsertIntoTable-Platforms.sql file)
2. run project use command
    ```
    dotnet build
    dotnet run
    ```
    type: *localhost:5000/graphql* in Browser and press Excute button (at top right) 
    ![db update](https://raw.githubusercontent.com/baodainguyen/graphQL/master/imgs/test001.png)

### Tag: v1.4_Query-MapGraphQL
1. Add Query class (in GraphQL.cs file)
2. Add service (GraphQLServer, QueryType) from method ConfigureServices in Startup.cs
3. Update UseEndpoints with MapGraphQL from method Configure in Startup.cs


### Tag: v1.3_MigrateWithSqlServer
**Use in VS Code's TERMINAL**
1. Check/install EntityFramework (EF):
    
    ``` 
    dotnet ef 
    ```    
    Install command if not
    ``` 
    dotnet tool install --global dotnet-ef 
    ```
    Update command (use -g instead --global)
    ```
    dotnet tool update -g dotnet-ef
2. Migrate with Database in SqlServer:    
    
    If u want to generate Migrations by your self, let delete Migrations folder and run this code
    ```
    dotnet ef migrations add AddPlatformToDb
    ```
    Command line to connect and create Database in SqlServer
    ``` 
    dotnet ef database update
    ```
    Image below after run command ef database update
    ![db update](https://raw.githubusercontent.com/baodainguyen/graphQL/master/imgs/dotnetEfDatabaseUpdate.png)
    

### Tag: v1.2_Add-Dependency-EF-DB-ConnectionString
1. Inject dependency IConfiguration into Startup.cs constructor
2. Add Models into project (Platform class)
3. Add Data into project (AppDbContext class)
4. Set ConnectionStrings in appsettings.Development.json
5. Get ConnectionStrings by ConfigureServices method in Startup.cs

### Tag: v1.1_add-packageRefs
**Use in VS Code's TERMINAL**
``` 
dotnet add package HotChocolate.AspNetCore
dotnet add package HotChocolate.Data.Entityframework
dotnet add package Microsoft.EntityframeworkCore.Design
dotnet add package Microsoft.EntityframeworkCore.SqlServer
dotnet add package GraphQL.Server.Ui.Voyager
```

### Tag: v1.0_init-project
**Use in VS Code's TERMINAL**
1. Create new project: ``` dotnet new web -n GraphQL -f net5.0 ```
2. Open project: ``` code -r GraphQL ```