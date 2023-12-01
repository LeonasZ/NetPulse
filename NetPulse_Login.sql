-- Tablas para el Login
Create database UserLogin
GO
Use UserLogin
GO
Create Table Usuarios(
    IdUsuario int primary key identity (1, 1),
    Nombre varchar(50) not null,
    Apellido varchar (50),
    Usuario varchar(50) not null unique,
    Contraseña varchar(50),
    Mail varchar(50) not null,
    Telefono varchar(12),
    TipoUsuario varchar(50) Constraint CHK_TipoUsuario Check (TipoUsuario IN ('Tecnico', 'Admin'))
)
Go
Insert into Usuarios values ('Admin 1', 'Admin 1', 'Adm1', '1234', 'admin@mail.com', '', 'Admin'),
                            ('Tecnico 1', 'Tecnico1', 'Tec1', 't1', 'tecnico@mail.com', '', 'Tecnico');
Go
Select * From Usuarios

