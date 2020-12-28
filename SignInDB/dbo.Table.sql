CREATE TABLE [dbo].[Toolsdb]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Felhasznalo] VARCHAR(50) NULL,
    [Date] VARCHAR(50) NULL, 
    [Marka] VARCHAR(50) NULL, 
    [Tipus] VARCHAR(50) NULL, 
    [Tartozek] VARCHAR(200) NULL, 
    [Hordozhato] BIT NULL, 
    [Javit] BIT NULL, 
    [Megjegyzes] VARCHAR(300) NULL, 
    [Vezeteknev] VARCHAR(50) NULL, 
    [Keresztnev] VARCHAR(50) NULL, 
    [Telefon] INT NULL, 
    [Email] VARCHAR(50) NULL
)
