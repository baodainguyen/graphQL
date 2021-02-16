-- Insert rows into table 'Platforms'
INSERT INTO Platforms
( -- columns to insert data into
 [Name], [LicenseKey]
)
VALUES
( -- first row: values for the columns in the list above
 '.Net 5', NULL
),
( -- second row: values for the columns in the list above
 'Docker', NULL
),
(
 'Windows', 'DAINB-KLOON-2021-16FEB-1207'
)
-- add more rows here
GO 
SELECT TOP (1000) [Id]
      ,[Name]
      ,[LicenseKey]
  FROM [GraphQL].[dbo].[Platforms]