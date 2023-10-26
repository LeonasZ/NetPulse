-- Crear la base de datos
CREATE DATABASE BD_SXA
GO
-- Usar la base de datos
USE BD_SXA
GO
drop table clientes
-- Tabla de clientes
CREATE TABLE clientes (
    nroCliente INT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Direccion VARCHAR(255),
    Barrio VARCHAR(255),
    telefono VARCHAR(20),
    mail VARCHAR(255),
    dni VARCHAR(20) NOT NULL,
    fechaAlta DATETIME,
    formaPago VARCHAR(50),
    activo bit,
    nroPlan INT,
    FOREIGN KEY (nroPlan) REFERENCES planes(nroPlan)
)
go
-- Tabla de planes
CREATE TABLE planes (
    nroPlan INT PRIMARY KEY,
    cantMegas VARCHAR(50),
    precio DECIMAL(10, 2),
    activo bit
)
go
-- Tabla de abonos mensuales
CREATE TABLE abonos_mensuales (
    idAbono INT PRIMARY KEY,
    nroCliente INT,
    fechaAbono DATE,
    monto DECIMAL(10, 2),
    estadoPago VARCHAR(20),
    formaPago VARCHAR(50),
    -- Otros campos relevantes
    FOREIGN KEY (nroCliente) REFERENCES clientes(nroCliente)
)
go
-- Tabla de instalaciones
CREATE TABLE instalaciones (
    idInstalacion INT PRIMARY KEY,
    nroCliente INT,
    fechaInstalacion DATE,
    tecnicoResponsable VARCHAR(255),
    componentesInstalados TEXT,
    comentarios TEXT,
    estadoRealizacion VARCHAR(50),
    FOREIGN KEY (nroCliente) REFERENCES clientes(nroCliente)
)
go
-- Tabla de servicios realizados
CREATE TABLE servicios_realizados (
    idServicio INT PRIMARY KEY,
    nroCliente INT,
    fechaServicio DATE,
    tecnicoResponsable VARCHAR(255),
    descripcionServicio TEXT,
    costo DECIMAL(10, 2),
    componentesCambiados TEXT,
    comentarios TEXT,
    estadoRealizacion VARCHAR(50),
    FOREIGN KEY (nroCliente) REFERENCES clientes(nroCliente)
)
GO

-- Tabla de desinstalaciones
CREATE TABLE desinstalaciones (
    idDesinstalacion INT PRIMARY KEY,
    nroCliente INT,
    fechaDesinstalacion DATE,
    tecnicoResponsable VARCHAR(255),
    razonDesinstalacion TEXT,
    componentesRetirados TEXT,
    comentarios TEXT,
    estadoRealizacion VARCHAR(50),
    FOREIGN KEY (nroCliente) REFERENCES clientes(nroCliente)
)




INSERT INTO clientes (nroCliente, Nombre, Direccion, Barrio, telefono, mail, dni, fechaAlta, formaPago,activo,nroPlan)
VALUES
(1170, 'Cabrera Hector Miguel', 'Ciudad parque las rosas manzana 38 casa 12', 'PLR', '3517 60-4237', 'Cabreraceleste974@gmail.com', '31557702', '2023-07-28', 'T',1,2),
(1171, 'Alexis maximiliano Argüello Quiroga', 'San Marino 3875 o ( lote 2 manzana 3).', 'PLR', '3516 20-9714', 'alexmax744@gmail.com', '34316716', '2023-07-11', 'T',1,3),
(1172, 'Gloria Jimena Salas', 'Cambay 5370  Barrio Carrara', 'CA', '3512 95-1064', 'gloriajsalas22@hotmail.com', '30330008', '2023-08-28', 'T',1,1),
(1173, 'Hugo Andres Flores', 'Bonn 4385 Barrio Estación Flores', 'EF', '3518 12-5879', 'hugoandresf9@gmail.com', '14409678', '2023-08-31', 'T',1,1),
(1174, 'Maximiliano jeremías villada', 'Roque arias 3618 barrio estación flores', 'EF', '3517 60-8633', 'achivillada@gmail.com', '33752252', '2023-08-07', 'T',1,1),
(1175, 'Julieta Gabriela arce', 'Parque las rosas manzana 46 casa 6', 'PLR', '3517 43-2707', 'Hanseltian2327@gmail.com', '32787061', '2023-07-27', 'T',1,2),
(1176, 'Verónica Isabel Escudero', 'María Brizuela 3137 Barrio Villa Aspacia', 'VA', '3513 47-4867', 'verisabel3007@gmail.com', '25608264', '2023-09-15', 'T',1,2),
(1177, 'Jaquelina emilce tosi sanchez', 'Henderson 5467 carrara', 'CA', '3517 73-4013', 'Tosiestudio@gmail.com', '40521639', '2023-09-19', 'T',1,3),
(1178, 'Julio Nicolás Vildoza Maltés', 'https://www.google.com/maps/dir/-31.4510948,-64.2395311/@-31.4510948,-64.242106,17z?hl=es&entry=ttu', 'PLR', '3512 48-5720', 'julio.nicolas31667@gmail.com', '31667694', '2023-08-02', 'T',1,1),
(1179, 'Rocio Belen Arguello', 'calle pública sin numero', 'EF', '3517 53-3359', 'rociobelen52@outlook.com', '42585304', '2023-09-25', 'T',1,3),
(1180, 'Carlos Ramón Nieto', 'B° parque las rosas mza44 csa21', 'PLR', '3517 50-5877', 'n23carlos@gmail.com', '17530865', '2023-09-21', 'T',1,3),
(1181, 'Andrés Rolando González', 'Psj 52 casa 63, Villa Aspacia', 'VA', '3517 32-0353', 'andy40684909@gmail.com', '40684909', '2023-10-05', 'T',1,2),
(1182, 'Díaz Brenda Aldana', 'Ciudad de nieva 3858', 'CA', '3513 39-2543', 'brendiaz40402@gmail.com', '40402959', '2023-10-05', 'T',1,3),
(1183, 'Angela Lorena Tosi Sánchez', 'El alto 3849', 'SA', '3512 09-2093', 'lore1947@outlook.es', '1', '2023-10-05', 'T',1,3),
(1184, 'Gisel Sosa', 'San Marino 45', 'PLR', '3513 68-0839', 'sosagise32@gmail.com', '39080827', '2023-10-11', 'T',1,2),
(1185, 'Yanina Alejandra Bazan', 'Parque las Rosas mza:4 Lote:28', 'PLR', '3516 87-1920', 'yaninaariel34@gmail.com', '32292560', '2023-10-11', 'T',1,1);


INSERT into planes (nroPlan,precio,cantMegas,activo)
VALUES(1,4100,12,1),(2,5200,18,1),(3,6600,25,1)