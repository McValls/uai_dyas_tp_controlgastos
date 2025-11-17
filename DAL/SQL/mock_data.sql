-- Mock Data for Control_Gastos Database
-- Delete existing data (respecting foreign key constraints)
DELETE FROM Prestamos;
DELETE FROM Movimientos;
DELETE FROM Usuarios where username not like 'admin';

-- Password for all users: "Usuario1234"
-- SHA256 Hash: 8a82a5f6fc722db8a57e25b508f5a008ac65dacffe4ead217e4ebdc31f8a4348

-- Insert Users (Tipo 1 = User, 0 = Admin)
INSERT INTO Usuarios (Id, Username, Tipo, Password) VALUES
(1, 'User1', 1, '8a82a5f6fc722db8a57e25b508f5a008ac65dacffe4ead217e4ebdc31f8a4348'),
(2, 'User2', 1, '8a82a5f6fc722db8a57e25b508f5a008ac65dacffe4ead217e4ebdc31f8a4348'),
(3, 'User3', 1, '8a82a5f6fc722db8a57e25b508f5a008ac65dacffe4ead217e4ebdc31f8a4348'),
(4, 'User4', 1, '8a82a5f6fc722db8a57e25b508f5a008ac65dacffe4ead217e4ebdc31f8a4348');

-- User1: Lot more income than outcomes (High savings scenario)
-- Total Income: $125,000 | Total Expenses: $25,000 | Balance: +$100,000
INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId) VALUES
(1, 'Ingreso', 50000.00, 0, 'Salario mensual', '2025-10-01 09:00:00', 1),
(2, 'Ingreso', 35000.00, 0, 'Bonus trimestral', '2025-10-05 10:30:00', 1),
(3, 'Ingreso', 20000.00, 0, 'Proyecto freelance', '2025-10-10 14:00:00', 1),
(4, 'Ingreso', 15000.00, 0, 'Venta de equipamiento', '2025-10-15 11:00:00', 1),
(5, 'Ingreso', 5000.00, 0, 'Reembolso de gastos', '2025-10-20 16:00:00', 1),
(6, 'Gasto', 8000.00, 0, 'Alquiler', '2025-10-02 08:00:00', 1),
(7, 'Gasto', 5000.00, 0, 'Supermercado', '2025-10-07 18:00:00', 1),
(8, 'Gasto', 3000.00, 0, 'Servicios (luz, gas, agua)', '2025-10-12 12:00:00', 1),
(9, 'Gasto', 6000.00, 0, 'Entretenimiento', '2025-10-18 20:00:00', 1),
(10, 'Gasto', 3000.00, 0, 'Transporte', '2025-10-25 07:30:00', 1);

-- User2: Balanced finances (Income ≈ Expenses)
-- Total Income: $48,000 | Total Expenses: $47,500 | Balance: +$500
INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId) VALUES
(11, 'Ingreso', 40000.00, 0, 'Salario mensual', '2025-10-01 09:00:00', 2),
(12, 'Ingreso', 5000.00, 0, 'Horas extras', '2025-10-08 10:00:00', 2),
(13, 'Ingreso', 3000.00, 0, 'Venta online', '2025-10-15 15:00:00', 2),
(14, 'Gasto', 15000.00, 0, 'Alquiler', '2025-10-02 08:00:00', 2),
(15, 'Gasto', 8000.00, 0, 'Supermercado', '2025-10-05 19:00:00', 2),
(16, 'Gasto', 6000.00, 0, 'Servicios', '2025-10-10 11:00:00', 2),
(17, 'Gasto', 4500.00, 0, 'Transporte y combustible', '2025-10-12 07:00:00', 2),
(18, 'Gasto', 5000.00, 0, 'Salud y medicamentos', '2025-10-18 14:00:00', 2),
(19, 'Gasto', 6000.00, 0, 'Ropa y calzado', '2025-10-22 16:00:00', 2),
(20, 'Gasto', 3000.00, 0, 'Celular e internet', '2025-10-28 10:00:00', 2);

-- User3: Balanced finances (Income ≈ Expenses, slightly positive)
-- Total Income: $55,000 | Total Expenses: $53,000 | Balance: +$2,000
INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId) VALUES
(21, 'Ingreso', 42000.00, 0, 'Salario mensual', '2025-10-01 09:00:00', 3),
(22, 'Ingreso', 8000.00, 0, 'Comisiones por ventas', '2025-10-10 11:00:00', 3),
(23, 'Ingreso', 5000.00, 0, 'Trabajo part-time', '2025-10-20 18:00:00', 3),
(24, 'Gasto', 18000.00, 0, 'Alquiler', '2025-10-02 08:00:00', 3),
(25, 'Gasto', 10000.00, 0, 'Supermercado y compras', '2025-10-06 20:00:00', 3),
(26, 'Gasto', 7000.00, 0, 'Servicios públicos', '2025-10-11 12:00:00', 3),
(27, 'Gasto', 5000.00, 0, 'Educación y cursos', '2025-10-14 15:00:00', 3),
(28, 'Gasto', 4000.00, 0, 'Gimnasio y deporte', '2025-10-17 07:00:00', 3),
(29, 'Gasto', 6000.00, 0, 'Restaurantes y delivery', '2025-10-23 21:00:00', 3),
(30, 'Gasto', 3000.00, 0, 'Suscripciones digitales', '2025-10-27 10:00:00', 3);

-- User4: Lot of debt (Expenses >> Income)
-- Total Income: $30,000 | Total Expenses: $95,000 | Balance: -$65,000
INSERT INTO Movimientos (Id, Tipo, Monto, Moneda, Descripcion, Fecha, UsuarioId) VALUES
(31, 'Ingreso', 25000.00, 0, 'Salario mensual', '2025-10-01 09:00:00', 4),
(32, 'Ingreso', 5000.00, 0, 'Trabajo ocasional', '2025-10-15 14:00:00', 4),
(33, 'Gasto', 20000.00, 0, 'Alquiler', '2025-10-02 08:00:00', 4),
(34, 'Gasto', 15000.00, 0, 'Pago de deudas de tarjeta', '2025-10-03 10:00:00', 4),
(35, 'Gasto', 12000.00, 0, 'Reparación de auto urgente', '2025-10-05 12:00:00', 4),
(36, 'Gasto', 10000.00, 0, 'Gastos médicos', '2025-10-08 15:00:00', 4),
(37, 'Gasto', 8000.00, 0, 'Supermercado', '2025-10-12 19:00:00', 4),
(38, 'Gasto', 12000.00, 0, 'Préstamo personal - cuota', '2025-10-15 11:00:00', 4),
(39, 'Gasto', 10000.00, 0, 'Multas y pagos atrasados', '2025-10-20 13:00:00', 4),
(40, 'Gasto', 8000.00, 0, 'Servicios y deudas varias', '2025-10-25 16:00:00', 4);

