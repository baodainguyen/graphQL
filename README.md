# graphQL
pratice dotnet an graphql
### Tag: v3.1_Subscription
1. add class Subscription in Queries.cs
2. In Startup.cs
    * UseWebSockets in Configure method from Startup.cs
    * AddSubscriptionType, AddInMemorySubscriptions in ConfigureServices from Startup.cs
3. in Mutation from Queries.cs
    * add params ITopicEventSender, CancellationToken in AddPlatformAsync method

### Tag: v3.0_Mutation-from-API
1. add class Mutation in Queries.cs
2. add records
    * in Command.cs (AddCommandPayload, AddCommandInput)
    * in Platform.cs (AddPlatformPayload, AddPlatformInput)
3. add service AddMutationType in ConfigureServices from Startup.cs

### Tag: v2.3_Filter-Sort
* Add [UseFiltering] and [UseSorting] in Query class of GraphQL.cs
* AddFiltering and Sorting service in ConfigureServices of Startup.cs

### Tag: v2.2_Type-for-CommandAndPlatform
1. Add PlatformType and CommandType class in GraphQL.cs
    * Ignore LicenseKey in Configure function PlatformType
2. Add Type of ConfigureServices method in Startup.cs
3. Remove Projections
    * [UseProjection] annotation in Query class from GraphQL.cs
    * Rm AddProjections method in ConfigureServices from Startup.cs

### Tag: v2.1_UpdateQuery-AddDescriptionInGraphVoyager
1. Add GetCommand method in Query class of GraphQL.cs
2. Add GraphQLDescription in Platform class of Models.cs

    *dotnet run* and type on browser: http://localhost:5000/graphql-voyager
    ![query commands](https://raw.githubusercontent.com/baodainguyen/graphQL/master/imgs/graphqlVoyagerDescription.png)

### Tag: v2.0_UpdateEFWithCommand-Migration
1. Update Entity
    * Add Command class in Models.cs
    * Add List Command in Platform
    * Add UseProjection annotation into Query in GraphQL.cs
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
3. AddProjections service into ConfigureServices in Startup.cs
    run project ``` dotnet run ``` and query in example
    ![query commands](https://raw.githubusercontent.com/baodainguyen/graphQL/master/imgs/graphQlNested.png)


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

# Git command
1. Use `git tag -a v1.0_NameOf-Tag -m 'commit tag name v1.0'` for create new tag
2. Type `git push origin --tags` to push tag on git's repo

# Credit and Ref
Thanks for tutorial: (Les Jackson channel)
    https://www.youtube.com/watch?reload=9&v=HuN94qNwQmM