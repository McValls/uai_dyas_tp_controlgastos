CREATE PROCEDURE ObtenerConfiguracionPrestamos
AS
BEGIN
	SELECT 
		Id AS Prestamo_Id,
		TasaInteres AS Prestamo_TasaInteres,
		PlazoMeses AS Prestamo_PlazoMeses
	FROM Configuracion_Prestamos;
END;

