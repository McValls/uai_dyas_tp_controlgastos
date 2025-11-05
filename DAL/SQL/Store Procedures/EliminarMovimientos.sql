CREATE PROCEDURE EliminarMovimientos
	@Id INT
AS
BEGIN
	DELETE FROM Movimientos
	WHERE Id = @Id;
END;

