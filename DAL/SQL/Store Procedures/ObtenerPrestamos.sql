CREATE PROCEDURE ObtenerPrestamos
	@UsuarioId INT
AS
BEGIN
	SELECT 
		P.Id AS Prestamos_Id, 
		P.Monto AS Prestamos_Monto, 
		P.FechaCreacion AS Prestamos_FechaCreacion,
		CP.Id AS Prestamo_Id,
		CP.TasaInteres AS Prestamo_TasaInteres,
		CP.PlazoMeses AS Prestamo_PlazoMeses,
		U.Id AS Usuarios_id,
		U.Username AS Usuarios_username,
		U.Password AS Usuarios_password,
		U.Tipo AS Usuarios_tipo
	FROM Prestamos P
	INNER JOIN Configuracion_Prestamos CP ON P.ConfiguracionPrestamoId = CP.Id
	INNER JOIN Usuarios U ON P.UsuarioId = U.Id
	WHERE P.UsuarioId = @UsuarioId;
END;

