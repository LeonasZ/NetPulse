CREATE DATABASE BD_NetPulse
Go

USE BD_NetPulse
Go

CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY identity (1, 1),
    Nombre VARCHAR(255) NOT NULL,
    Telefono VARCHAR(20),
    Mail VARCHAR(255),
    Dni VARCHAR(20) NOT NULL,
    FechaAlta DATETIME,
    Activo bit,
)
Go

Create Table Domicilio(
    IdDomicilio int primary key identity (1, 1),
    Direccion VARCHAR(255),
    Barrio varchar(255),
    Ciudad varchar(255),
    Comentario varchar(255)
)
Go

Create Table TPlan(
    IdPlan INT PRIMARY KEY identity (1, 1),
    CantidadMegas int,
    Precio money
)
Go

Create Table FormaPago(
    IdFormaPago int primary key identity (1, 1),
    Nombre varchar(50)
)
Go

Create Table AbonoMensual(
    IdAbonoMensual int primary key identity (1, 1),
    IdFormaPago int,
    FechaVencimiento1 datetime,
    FechaVencimiento2 datetime,
    Pagado bit,
    -- //////////////////
    FOREIGN KEY (IdFormaPago) REFERENCES FormaPago (IdFormaPago)
)
Go

CREATE TABLE Servicio (
    IdServicio INT PRIMARY KEY identity (1, 1),
    IdCliente INT,
    IdDomicilio int,
    IdPlan int,
    IdAbonoMensual int,
    FechaAlta datetime,
    Estado bit,
    --TecnicoResponsable VARCHAR(255),
    Comentarios text,
    FOREIGN KEY (IdCliente) REFERENCES Clientes (IdCliente),
    FOREIGN KEY (IdDomicilio) REFERENCES Domicilio (IdDomicilio),
    FOREIGN KEY (IdPlan) REFERENCES TPlan (IdPlan),
    FOREIGN KEY (IdAbonoMensual) REFERENCES AbonoMensual (IdAbonoMensual)
)
Go
Create Table Tecnico(
    IdTecnico int PRIMARY KEY identity (1, 1),
    Nombre VARCHAR(50),
    Contacto VARCHAR(50),
    FechaIncorporacion datetime,
    Estado bit
)
Go
Create Table TipoMantenimiento(
    IdTipoMantenimiento int primary key identity (1, 1),
    Nombre varchar(50)
)
Go

CREATE TABLE Mantenimiento (
    IdMantenimiento int primary key identity (1, 1),
    IdServicio int,
    Fecha DATETIME,
    IdTecnico int,
    Descripcion text,
    --Costo REVISAR
    IdTipoMantenimiento int,
    --ComponentesCambiados text,
    Comentarios text,
    EstadoRealizacion bit,
    FOREIGN KEY (IdServicio) REFERENCES Servicio (IdServicio),
    FOREIGN KEY (IdTecnico) REFERENCES Tecnico (IdTecnico),
    FOREIGN KEY (IdTipoMantenimiento) REFERENCES TipoMantenimiento (IdTipoMantenimiento),
)
Go

INSERT INTO Clientes (Nombre, Telefono, Mail, Dni, FechaAlta, Activo)
VALUES
    ('Cliente1', '123-456-7890', 'cliente1@example.com', '123456789', GETDATE(), 1),
    ('Cliente2', '987-654-3210', 'cliente2@example.com', '987654321', GETDATE(), 1),
    ('Cliente3', '555-555-5555', 'cliente3@example.com', '555555555', GETDATE(), 1),
    ('Cliente4', '111-111-1111', 'cliente4@example.com', '111111111', GETDATE(), 1),
    ('Cliente5', '222-222-2222', 'cliente5@example.com', '222222222', GETDATE(), 1),
    ('Cliente6', '333-333-3333', 'cliente6@example.com', '333333333', GETDATE(), 1),
    ('Cliente7', '444-444-4444', 'cliente7@example.com', '444444444', GETDATE(), 1),
    ('Cliente8', '666-666-6666', 'cliente8@example.com', '666666666', GETDATE(), 1),
    ('Cliente9', '777-777-7777', 'cliente9@example.com', '777777777', GETDATE(), 1),
    ('Cliente10', '999-999-9999', 'cliente10@example.com', '999999999', GETDATE(), 1);

INSERT INTO Domicilio (Direccion, Barrio, Ciudad, Comentario)
VALUES
    ('Calle 1, Nº 123', 'Barrio A', 'Ciudad X', 'Comentario 1'),
    ('Calle 2, Nº 456', 'Barrio B', 'Ciudad Y', 'Comentario 2'),
    ('Calle 3, Nº 789', 'Barrio C', 'Ciudad Z', 'Comentario 3'),
    ('Calle 4, Nº 1011', 'Barrio D', 'Ciudad W', 'Comentario 4'),
    ('Calle 5, Nº 1213', 'Barrio E', 'Ciudad V', 'Comentario 5'),
    ('Calle 6, Nº 1415', 'Barrio F', 'Ciudad U', 'Comentario 6'),
    ('Calle 7, Nº 1617', 'Barrio G', 'Ciudad T', 'Comentario 7'),
    ('Calle 8, Nº 1819', 'Barrio H', 'Ciudad S', 'Comentario 8'),
    ('Calle 9, Nº 2021', 'Barrio I', 'Ciudad R', 'Comentario 9'),
    ('Calle 10, Nº 2223', 'Barrio J', 'Ciudad Q', 'Comentario 10');

INSERT INTO TPlan (CantidadMegas, Precio)
VALUES
    (10, 29.99),
    (25, 49.99),
    (50, 69.99),
    (100, 89.99);

INSERT INTO FormaPago (Nombre)
VALUES
    ('Tarjeta de Crédito'),
    ('Transferencia Bancaria'),
    ('Efectivo');

INSERT INTO AbonoMensual (IdFormaPago, FechaVencimiento1, FechaVencimiento2, Pagado)
VALUES
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 0),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 1),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 0),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 1),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 0),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 1),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 0),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 1),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 0),
    (1, DATEADD(MONTH, 1, GETDATE()), DATEADD(MONTH, 2, GETDATE()), 1);

INSERT INTO Servicio (IdCliente, IdDomicilio, IdPlan, IdAbonoMensual, FechaAlta, Estado, Comentarios)
VALUES
    (1, 1, 1, 1, GETDATE(), 1, 'Comentario 1'),
    (2, 2, 2, 2, GETDATE(), 0, 'Comentario 2'),
    (3, 3, 3, 3, GETDATE(), 1, 'Comentario 3'),
    (4, 4, 4, 4, GETDATE(), 0, 'Comentario 4'),
    (5, 5, 1, 5, GETDATE(), 1, 'Comentario 5'),
    (6, 6, 2, 6, GETDATE(), 0, 'Comentario 6'),
    (7, 7, 3, 7, GETDATE(), 1, 'Comentario 7'),
    (8, 8, 4, 8, GETDATE(), 0, 'Comentario 8'),
    (9, 9, 1, 9, GETDATE(), 1, 'Comentario 9'),
    (10, 10, 2, 10, GETDATE(), 0, 'Comentario 10');

INSERT INTO Tecnico (Nombre, Contacto, FechaIncorporacion, Estado)
VALUES
    ('Técnico1', '123-456-7890', GETDATE(), 1),
    ('Técnico2', '987-654-3210', GETDATE(), 1),
    ('Técnico3', '555-555-5555', GETDATE(), 1);

INSERT INTO TipoMantenimiento (Nombre)
VALUES
    ('Mantenimiento Preventivo'),
    ('Mantenimiento Correctivo'),
    ('Mantenimiento Predictivo'),
    ('Mantenimiento de Emergencia');

INSERT INTO Mantenimiento (IdServicio, Fecha, IdTecnico, Descripcion, IdTipoMantenimiento, Comentarios, EstadoRealizacion)
VALUES
    (1, GETDATE(), 1, 'Mantenimiento 1', 1, 'Comentario Mantenimiento 1', 1),
    (2, GETDATE(), 2, 'Mantenimiento 2', 2, 'Comentario Mantenimiento 2', 0),
    (3, GETDATE(), 1, 'Mantenimiento 3', 3, 'Comentario Mantenimiento 3', 1),
    (4, GETDATE(), 3, 'Mantenimiento 4', 4, 'Comentario Mantenimiento 4', 0),
    (5, GETDATE(), 2, 'Mantenimiento 5', 1, 'Comentario Mantenimiento 5', 1),
    (6, GETDATE(), 1, 'Mantenimiento 6', 2, 'Comentario Mantenimiento 6', 0),
    (7, GETDATE(), 3, 'Mantenimiento 7', 3, 'Comentario Mantenimiento 7', 1),
    (8, GETDATE(), 2, 'Mantenimiento 8', 4, 'Comentario Mantenimiento 8', 0),
    (9, GETDATE(), 1, 'Mantenimiento 9', 1, 'Comentario Mantenimiento 9', 1),
    (10, GETDATE(), 3, 'Mantenimiento 10', 2, 'Comentario Mantenimiento 10', 0);
