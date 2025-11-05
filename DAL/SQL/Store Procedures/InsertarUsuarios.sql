CREATE PROCEDURE InsertarUsuarios
	@Username NVARCHAR(100),
	@Password NVARCHAR(255),
	@Tipo INT
AS
BEGIN
	DECLARE @NewId INT;
	
	SELECT @NewId = COALESCE(MAX(Id), 0) + 1 FROM Usuarios;
	IF @NewId < 1
		SET @NewId = 1;
	
	INSERT INTO Usuarios (Id, Username, Password, Tipo)
	VALUES (@NewId, @Username, @Password, @Tipo);
	
	SELECT @NewId AS Id;
END;

