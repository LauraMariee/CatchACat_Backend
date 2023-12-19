USE master
GO

-- Create Database
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'Catch-A-Cat'
)
CREATE DATABASE [Catch-A-Cat]
GO

-----------------------------------------------------------------------
-- TABLES
-----------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatType' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.CatType', 'U') IS NOT NULL
	DROP TABLE dbo.CatType
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.CatType
(
   ID				INT    NOT NULL   PRIMARY KEY, -- primary key column
   cat_type_name    [NVARCHAR](50)  NOT NULL,
   weakness			[NVARCHAR](50)  NOT NULL,
);
GO

-- Insert rows into table 'CatName'
INSERT INTO dbo.CatType
   ([ID],[cat_type_name],[weakness])
VALUES
   (0, N'Fire', N'Water'),
   (1, N'Water', N'Grass'),
   (2, N'Grass', N'Fire')
GO

------------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatTable' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Cat', 'U') IS NOT NULL
	DROP TABLE dbo.Cat
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.Cat
(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY, --Primary 
	cat_type_ID     INT NOT NULL,
	name_ID			INT NOT NULL,
	rarity_ID		INT NOT NULL,
	model_name		[NVARCHAR](50) NOT NULL,
);
GO

-- SET IDENTITY_INSERT to ON.  
SET IDENTITY_INSERT dbo.Cat ON;  
GO 
-- Insert rows into table 'CatTable'
INSERT INTO dbo.Cat
   ([ID],[cat_type_ID],[name_ID], [rarity_ID], [model_name])
VALUES
   (0, 0, 0, 0, N'charccoal1'),
   (1, 0, 1, 1, N'campfire1'),
   (2, 1, 2, 2, N'fjord1'),
   (3, 1, 3, 1, N'open_sea1')
GO

------------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatName' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.CatName', 'U') IS NOT NULL
	DROP TABLE dbo.CatName
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.CatName
(
	ID				INT NOT NULL   PRIMARY KEY, -- primary key column
	name_en			[NVARCHAR](50) NOT NULL,
	name_de			[NVARCHAR](50) NOT NULL,
);
GO

-- Insert rows into table 'CatTable'
INSERT INTO dbo.CatName
   ([ID],[name_en],[name_de])
VALUES
   (0, N'Charccoal', N'Holzkohle'),
   (1, N'Campfire', N'Lagerfeuer'),
   (2, N'Fjord', N'Fjord'),
   (3, N'Open Sea', N'Offenes Meer')
GO

-----------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatTable' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Rarity', 'U') IS NOT NULL
	DROP TABLE dbo.Rarity
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.Rarity
(
	ID				INT NOT NULL   PRIMARY KEY, -- primary key column
	rarity_name_en			[NVARCHAR](50) NOT NULL,
	rarity_name_de			[NVARCHAR](50) NOT NULL,
);
GO

-- Insert rows into table 'CatTable'
INSERT INTO dbo.Rarity
   ([ID],[rarity_name_en],[rarity_name_de])
VALUES
   (0, N'Common', N'Common'),
   (1, N'Rare', N'Seltene'),
   (2, N'Ultra Rare', N'Ultra Selten')
GO

-----------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatTable' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Player', 'U') IS NOT NULL
	DROP TABLE dbo.Player
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.Player
(
	ID				INT NOT NULL   PRIMARY KEY, -- primary key column
	player_name			[NVARCHAR](50) NOT NULL,
);
GO


-- Insert rows into table 'CatTable'
INSERT INTO dbo.Player
   ([ID],[player_name])
VALUES
   (0, N'Bear'),
   (1, N'Cat'),
   (2, N'Bee')
GO

-----------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatTable' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Caught', 'U') IS NOT NULL
	DROP TABLE dbo.Caught
	GO

-- Create the table in the specified schema
CREATE TABLE dbo.Caught
(
	ID				INT NOT NULL   PRIMARY KEY, -- primary key column
	cat_ID			INT NOT NULL,
);
GO


-- Insert rows into table 'CatTable'
INSERT INTO dbo.Caught
   ([ID],[cat_ID])
VALUES
   (0, 2),
   (1, 1),
   (2, 1)
GO

-----------------------------------------------------------------------
-- VIEWS
------------------------------------------------------------------------

USE [Catch-A-Cat]
-- Create a new table called 'CatName' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('CompleteCat', 'V') IS NOT NULL
	DROP VIEW CompleteCat
	GO
;

CREATE VIEW CompleteCat
AS
	SELECT cat.ID, cat.model_name, catType.cat_type_name, catType.weakness, catName.name_en, catName.name_de, rarity.rarity_name_en, rarity.rarity_name_de
	FROM dbo.Cat as cat
	INNER JOIN dbo.CatType as catType
		ON cat.cat_type_ID=catType.ID
	INNER JOIN dbo.CatName as catName
		ON cat.name_ID=catName.ID
	INNER JOIN dbo.Rarity as rarity
		ON cat.rarity_ID=rarity.ID
GO
;


--------------------------------------------------------------------------
-- PRINT DATA FOR DEBUG
--------------------------------------------------------------------------

--SELECT * FROM dbo.Cat;
--SELECT * FROM dbo.CatType;
--SELECT * FROM dbo.CatName;
--SELECT * FROM dbo.Rarity;

--------------------------------------------------------------------------

SELECT * FROM dbo.CompleteCat;
