ALTER PROC UserAdd

@username varchar(50),
@password varchar (50)
AS
	INSERT INTO Logind (username,password)
	Values (@username,@password)