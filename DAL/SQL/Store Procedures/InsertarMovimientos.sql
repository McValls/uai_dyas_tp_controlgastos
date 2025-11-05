CREATE PROCEDURE InsertarMovimientos
	@Tipo NVARCHAR(50),
	@Monto DECIMAL(18,2),
	@Moneda INT,
	@Descripcion NVARCHAR(500),
	@Fecha DATETIME,
	@UsuarioId INT
AS
BEGIN
	DECLARE @NewId INT;
	
	SELECT @NewId = COALESCE(MAX(Id), 0) + 1 FROM Movimientos;
	IF @NewId < 1
		SET @NewId = 1;
	
	INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId)
	VALUES (@NewId, @Tipo, @Monto, @Moneda, @Descripcion, @Fecha, @UsuarioId);
	
	SELECT @NewId AS Id;
END;

