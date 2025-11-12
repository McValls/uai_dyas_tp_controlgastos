CREATE PROCEDURE InsertarConfiguracionPrestamos
	@tasainteres DECIMAL(5,2),
	@plazomeses INT
AS
BEGIN
	DECLARE @NextId INT;
	
	SELECT @NextId = ISNULL(MAX(Id), 0) + 1 FROM Configuracion_Prestamos;
	
	INSERT INTO Configuracion_Prestamos (Id, TasaInteres, PlazoMeses)
	VALUES (@NextId, @tasainteres, @plazomeses);
END;

