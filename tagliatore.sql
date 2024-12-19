CREATE DATABASE TagliatoreDB;
GO

USE TagliatoreDB;
GO

-- Tabla Platillos
CREATE TABLE Platillos (
    ID_Platillo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Ingredientes NVARCHAR(MAX),
    Precio DECIMAL(10,2) NOT NULL,
    ImagenURL NVARCHAR(255)
);

-- Tabla Clientes
CREATE TABLE Clientes (
    ID_Cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100),
    Telefono NVARCHAR(20),
    DNI NVARCHAR(15)
);

-- Tabla Ordenes
CREATE TABLE Ordenes (
    ID_Orden INT IDENTITY(1,1) PRIMARY KEY,
    ID_Mesa INT NOT NULL,
    Estado NVARCHAR(50) DEFAULT 'Pendiente',
    Fecha DATETIME DEFAULT GETDATE()
);

-- Tabla OrdenDetalle
CREATE TABLE OrdenDetalle (
    ID_Detalle INT IDENTITY(1,1) PRIMARY KEY,
    ID_Orden INT FOREIGN KEY REFERENCES Ordenes(ID_Orden),
    ID_Platillo INT FOREIGN KEY REFERENCES Platillos(ID_Platillo),
    Cantidad INT NOT NULL
);

-- Tabla Meseros
CREATE TABLE Meseros (
    ID_Mesero INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Usuario NVARCHAR(50) UNIQUE NOT NULL,
    Estado BIT DEFAULT 1
);


-- tabla Platillos
INSERT INTO Platillos (Nombre, Ingredientes, Precio, ImagenURL)
VALUES 
('Pizza Margarita', 'Tomate, Mozzarella, Albahaca', 12.50, 'margarita.jpg'),
('Lasaña Boloñesa', 'Pasta, Carne, Salsa Boloñesa, Queso', 15.00, 'lasana.jpg'),
('Tiramisú', 'Café, Mascarpone, Cacao, Bizcocho', 7.00, 'tiramisu.jpg'),
('Risotto de Champiñones', 'Arroz, Champiñones, Parmesano', 13.50, 'risotto.jpg'),
('Panna Cotta', 'Crema, Vainilla, Frutos Rojos', 6.50, 'pannacotta.jpg');

--  tabla Clientes
INSERT INTO Clientes (Nombre, Correo, Telefono, DNI)
VALUES 
('Mario Rossi', 'mario.rossi@gmail.com', '987654321', '12345678'),
('Luigi Bianchi', 'luigi.bianchi@hotmail.com', '987654322', '87654321'),
('Giulia Verdi', 'giulia.verdi@yahoo.com', '987654323', '45612378'),
('Alessandro Neri', 'alessandro.neri@gmail.com', '987654324', '32145687'),
('Sofia Romano', 'sofia.romano@outlook.com', '987654325', '65432189');

-- tabla Meseros
INSERT INTO Meseros (Nombre, Usuario, Estado)
VALUES 
('Giuseppe Rossi', 'giuseppe123', 1),
('Antonio Bianchi', 'antonio456', 1),
('Maria Verdi', 'maria789', 1),
('Laura Romano', 'laura123', 1),
('Paolo Neri', 'paolo321', 1);

-- tabla Ordenes
INSERT INTO Ordenes (ID_Mesa, Estado, Fecha)
VALUES 
(1, 'Pendiente', GETDATE()),
(2, 'Entregado', GETDATE()),
(3, 'Pendiente', GETDATE()),
(4, 'Cancelado', GETDATE()),
(5, 'Entregado', GETDATE());

-- tabla OrdenDetalle
INSERT INTO OrdenDetalle (ID_Orden, ID_Platillo, Cantidad)
VALUES 
(1, 1, 2), 
(1, 3, 1), 
(2, 2, 1), 
(3, 4, 2),
(4, 5, 1),
(5, 3, 2);