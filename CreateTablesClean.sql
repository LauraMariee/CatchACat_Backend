USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'TutorialDB'
)
CREATE DATABASE [TutorialDB]
GO

-----------------------------------------------------------------------

USE [TutorialDB]
-- Create a new table called 'CatType' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.CatType', 'U') IS NOT NULL
DROP TABLE dbo.CatType
GO
-- Create the table in the specified schema
CREATE TABLE dbo.CatType
(
   ID        INT    NOT NULL   PRIMARY KEY, -- primary key column
   Name_EN      [NVARCHAR](50)  NOT NULL,
   Name_DE		[NVARCHAR](50)  NOT NULL,
);
GO

-- Insert rows into table 'CatName'
INSERT INTO dbo.CatType
   ([ID],[Name_EN],[Name_DE])
VALUES
   (1, N'Cheese', N'Käse'),
   (2, N'Pancake', N'Pfannkuchen'),
   (3, N'Biscuit', N'Kekse')
GO

------------------------------------------------------------------------

USE [TutorialDB]
-- Create a new table called 'CatTable' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.CatTable', 'U') IS NOT NULL
DROP TABLE dbo.CatTable
GO
-- Create the table in the specified schema
CREATE TABLE dbo.CatTable
(
   Nickname		[NVARCHAR](50)  NOT NULL,
   Rarity     [NVARCHAR](50)  NOT NULL,
   ModelID		[NVARCHAR](50)  NOT NULL,
   TypeID      [NVARCHAR](50)  NOT NULL,
);
GO

SELECT CatType.ID
FROM CatType
INNER JOIN CatTable ON CatTable.TypeID=CatType.ID;

-- Insert rows into table 'CatTable'
--INSERT INTO dbo.CatTable
   --[TypeID],[NickName],[Rarity],[ModelID])
--VALUES
   --(3, N'Cheese', N'Common', N'tabby_1')
--GO

--------------------------------------------------------------------------

 --SELECT * FROM dbo.CatTable;
 --SELECT * FROM dbo.CatType;