CREATE PROCEDURE ObtenerMovimientos
AS
BEGIN
	SELECT 
		M.Id AS Movimientos_Id, 
		M.Tipo AS Movimientos_Tipo, 
		M.Monto AS Movimientos_Monto, 
		M.Moneda AS Movimientos_Moneda, 
		M.Descripcion AS Movimientos_Descripcion, 
		M.Fecha AS Movimientos_Fecha,
		U.Id AS Usuarios_Id,
		U.Username AS Usuarios_Username,
		U.Password AS Usuarios_Password,
		U.Tipo AS Usuarios_Tipo
	FROM Movimientos M
	INNER JOIN Usuarios U ON M.UsuarioId = U.Id;
END;

