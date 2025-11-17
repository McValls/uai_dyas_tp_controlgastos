CREATE DATABASE Control_Gastos;

USE Control_Gastos;

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Tipo INT NOT NULL, -- 0 = Admin, 1 = User
    Password NVARCHAR(255) NOT NULL
);

CREATE TABLE Movimientos (
    Id INT PRIMARY KEY,
    Tipo NVARCHAR(50) NOT NULL CHECK (Tipo IN ('Gasto', 'Ingreso')),
    Monto DECIMAL(18,2) NOT NULL,
    Moneda INT NOT NULL, -- 0 = PESOS, 1 = DOLARES
    Descripcion NVARCHAR(500) NOT NULL,
    Fecha DATETIME NOT NULL,
    UsuarioId INT NOT NULL,
    CONSTRAINT FK_Movimientos_Usuarios FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

CREATE TABLE Configuracion_Prestamos (
    Id INT PRIMARY KEY,
    TasaInteres DECIMAL(5,2) NOT NULL,
    PlazoMeses INT NOT NULL
);

CREATE TABLE Prestamos (
    Id INT PRIMARY KEY,
    Monto DECIMAL(18,2) NOT NULL,
    ConfiguracionPrestamoId INT NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    UsuarioId INT NOT NULL,
    CONSTRAINT FK_Prestamos_ConfiguracionPrestamos FOREIGN KEY (ConfiguracionPrestamoId) REFERENCES Configuracion_Prestamos(Id),
    CONSTRAINT FK_Prestamos_Usuarios FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

