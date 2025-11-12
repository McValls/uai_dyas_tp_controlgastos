CREATE PROCEDURE EditarConfiguracionPrestamos
	@id INT,
	@tasainteres DECIMAL(5,2),
	@plazomeses INT
AS
BEGIN
	UPDATE Configuracion_Prestamos
	SET 
		TasaInteres = @tasainteres,
		PlazoMeses = @plazomeses
	WHERE Id = @id;
END;

