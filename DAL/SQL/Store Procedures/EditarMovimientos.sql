CREATE PROCEDURE EditarMovimientos
	@Id INT,
	@Tipo NVARCHAR(50),
	@Monto DECIMAL(18,2),
	@Moneda INT,
	@Descripcion NVARCHAR(500),
	@Fecha DATETIME,
	@UsuarioId INT
AS
BEGIN
	UPDATE Movimientos
	SET Tipo = @Tipo,
		Monto = @Monto,
		Moneda = @Moneda,
		Descripcion = @Descripcion,
		Fecha = @Fecha,
		UsuarioId = @UsuarioId
	WHERE Id = @Id;
END;

