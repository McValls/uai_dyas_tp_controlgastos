CREATE PROCEDURE EditarUsuarios
	@Id INT,
	@Username NVARCHAR(100),
	@Password NVARCHAR(255)
AS
BEGIN
	UPDATE Usuarios
	SET Username = @Username,
		Password = @Password
	WHERE Id = @Id;
END;

