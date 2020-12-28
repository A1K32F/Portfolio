CREATE PROC ToolsAdd



    @Felhasznalo VARCHAR (50) ,
    @Date        VARCHAR (50)  ,
    @Marka      VARCHAR (50) ,
    @Tipus       VARCHAR (50) ,
    @Tartozek    VARCHAR (200) ,
    @Hordozhato  BIT           ,
    @Javit       BIT           ,
    @Megjegyzes  VARCHAR (300) ,
    @Vezeteknev  VARCHAR (50)  ,
    @Keresztnev VARCHAR (50)  ,
    @Telefon     INT           ,
    @Email       VARCHAR (50) 
    

AS
	INSERT INTO Toolsdb(Felhasznalo,Date,Marka,Tipus,Tartozek,Hordozhato,Javit,Megjegyzes,Vezeteknev,Keresztnev,Telefon,Email)
	Values (@Felhasznalo,@Date,@Marka,@Tipus,@Tartozek,@Hordozhato,@Javit,@Megjegyzes,@Vezeteknev,@Keresztnev,@Telefon,@Email)