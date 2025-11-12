CREATE PROCEDURE BuscarMovimientos
	@UsuarioId INT,
	@mes INT,
	@anio INT,
	@moneda INT = NULL,
	@descripcion NVARCHAR(255) = NULL
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
	INNER JOIN Usuarios U ON M.UsuarioId = U.Id
	WHERE M.UsuarioId = @UsuarioId
		AND MONTH(M.Fecha) = @mes
		AND YEAR(M.Fecha) = @anio
		AND (@moneda IS NULL OR M.Moneda = @moneda)
		AND (@descripcion IS NULL OR M.Descripcion LIKE '%' + @descripcion + '%');
END;

