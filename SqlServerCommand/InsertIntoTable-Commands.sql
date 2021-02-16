-- Insert rows into table 'Commands'
INSERT INTO Commands
( -- columns to insert data into
 [HowTo], [CommandLine], [PlatformId]
)
VALUES
( -- first row: values for the columns in the list above
 'Build a project', 'dotnet build', 1
),
( -- second row: values for the columns in the list above
 'Run a project', 'dotnet run', 1
),
( -- second row: values for the columns in the list above
 'Start a docker compose', 'docker-compose up -d', 2
),
( -- second row: values for the columns in the list above
 'Stop a docker compose', 'docker-compose stop', 2
)
-- add more rows here
GO 
SELECT *
  FROM [GraphQL].[dbo].[Commands]