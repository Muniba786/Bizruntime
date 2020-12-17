/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Gender]
      ,[Desingnation]
      ,[Salary]
  FROM [CodeFirstEFCore].[dbo].[Employees]