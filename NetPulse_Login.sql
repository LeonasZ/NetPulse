-- Tablas para el Login
Create database UserLogin
GO
Use UserLogin
GO
Create Table Usuarios(
    IdUsuario int not null primary key identity (1, 1),
    Nombre varchar(50) null,
    Usuario varchar(50) not null unique,
    Contraseña varchar(50) null,
    TipoUsuario varchar(50) null
)
Go
Insert into Usuarios values ('Admin 1', 'Adm1', '1234', 'Admin'),
                            ('Tecnico 1', 'Tec1', 't1', 'Tecnico');
Go
Select * From Usuarios
