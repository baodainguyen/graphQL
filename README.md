# graphQL
pratice dotnet an graphql
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
    after run command below
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