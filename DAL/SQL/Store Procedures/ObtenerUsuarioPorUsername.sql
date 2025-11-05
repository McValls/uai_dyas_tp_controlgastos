CREATE PROCEDURE ObtenerUsuarioPorUsername
	@Username NVARCHAR(100)
AS
BEGIN
	SELECT 
		Id AS Usuarios_Id, 
		Username AS Usuarios_Username, 
		Password AS Usuarios_Password,
		Tipo AS Usuarios_Tipo
	FROM Usuarios
	WHERE Username = @Username;
END;

