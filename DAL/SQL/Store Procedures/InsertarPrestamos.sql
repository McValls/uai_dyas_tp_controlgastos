CREATE PROCEDURE InsertarPrestamos
	@Monto DECIMAL(18,2),
	@ConfiguracionPrestamoId INT,
	@FechaCreacion DATETIME,
	@UsuarioId INT
AS
BEGIN
	DECLARE @Descripcion NVARCHAR(500);
	
	INSERT INTO Prestamos (Id, Monto, ConfiguracionPrestamoId, FechaCreacion, UsuarioId)
	VALUES ((SELECT COALESCE(MAX(Id), 0) + 1 FROM Prestamos), @Monto, @ConfiguracionPrestamoId, @FechaCreacion, @UsuarioId);
	
	SET @Descripcion = 'Prestamo recibido - ID: ' + CAST((SELECT MAX(Id) FROM Prestamos) AS NVARCHAR(10));
	
	INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId)
	VALUES ((SELECT COALESCE(MAX(Id), 0) + 1 FROM Movimientos), 'Ingreso', @Monto, 0, @Descripcion, @FechaCreacion, @UsuarioId);
END;

