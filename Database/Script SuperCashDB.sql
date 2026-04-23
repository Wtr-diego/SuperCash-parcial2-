CREATE DATABASE SuperCashDB;
USE SuperCashDB;

CREATE TABLE Usuarios (
	ID_Usuario INT PRIMARY KEY IDENTITY(1,1),
	Nombres VARCHAR(50) NOT NULL,
	Apellidos VARCHAR(50) NOT NULL,
	Rol VARCHAR(50) -- Si es Vendedor o Admin.
);

CREATE TABLE Categoria (
    ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    CategoriaPadreId INT NULL, 
    Activo BIT DEFAULT 1,      
    Orden INT DEFAULT 0,
    IconoUrl NVARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    ColorHex NVARCHAR(7) DEFAULT '#2E86C1',
    CONSTRAINT FK_CategoriaPadre FOREIGN KEY (CategoriaPadreId) 
    REFERENCES Categoria(ID_Categoria)
);

CREATE TABLE Productos (
	ID_Producto INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(100) NOT NULL,
	Precio DECIMAL(10, 2) NOT NULL,
	Stock INT NOT NULL,
	ID_Categoria INT,
	FOREIGN KEY (ID_Categoria) REFERENCES Categoria(ID_Categoria)
);

CREATE TABLE Ventas (
	ID_Venta INT PRIMARY KEY IDENTITY(1,1),
	ID_Usuario INT,
	Fecha DATETIME DEFAULT GETDATE(),
	Total DECIMAL(10,2) NOT NULL,
	FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario)
);

CREATE TABLE DetalleVenta (
	ID_Detalle INT PRIMARY KEY IDENTITY(1,1),
	ID_Venta INT,
	ID_Producto INT,
	Cantidad INT NOT NULL,
	PrecioUnitario DECIMAL(10, 2) NOT NULL,
	Subtotal DECIMAL(10, 2) NOT NULL,
	FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta),
	FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);

CREATE TABLE Auditoria (
	ID_Auditoria INT PRIMARY KEY IDENTITY(1,1),
	ID_Usuario INT,
	FechaHora DATETIME DEFAULT GETDATE(),
	Accion VARCHAR(100) NOT NULL,
	Detalle VARCHAR(150),
	Modulo VARCHAR(50),
	FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario)
);

-- Datos de prueba
INSERT INTO Categoria (Nombre) VALUES ('Granos'), ('Lácteos'), ('Panadería');
INSERT INTO Usuarios (Nombres, Apellidos, Rol) VALUES ('Angel', 'Sanchez', 'Vendedor');
INSERT INTO Productos (Nombre, Precio, Stock, ID_Categoria) 
VALUES ('LB Arroz', 0.80, 30, 1), ('Leche', 1.75, 30, 2), ('Pan', 0.90, 5, 3);