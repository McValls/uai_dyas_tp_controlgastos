CREATE PROCEDURE EliminarConfiguracionPrestamos
	@id INT
AS
BEGIN
	DELETE FROM Configuracion_Prestamos
	WHERE Id = @id;
END;

