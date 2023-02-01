CREATE DATABASE INICIO
USE INICIO

CREATE TABLE tipos_usuarios(
Id_tipo INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL
);


create table Usuarios(
Id_usuarios INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (25) NOT NULL,
Apellido VARCHAR(25) NOT NULL,
Usuario VARCHAR (25) NOT NULL,
Contraseña VARCHAR (50)NOT NULL,
Id_tipo INT NOT NULL REFERENCES tipos_usuarios
);

select * from Usuarios	
INSERT INTO tipos_usuarios VALUES(1,'USUARIO')
INSERT INTO tipos_usuarios VALUES(2,'ADMIN')
INSERT INTO tipos_usuarios VALUES(3,'SECRETARIA')

INSERT INTO Usuarios VALUES (1, 'Alesso','Chavez','x@_alesso','2811',1)
INSERT INTO Usuarios VALUES (2, 'Dennis','Cheley','x@_den','2005',1)
INSERT INTO Usuarios VALUES (3, 'Carl','Frank','x@_carl','17',1)


SELECT * FROM usuarios


CREATE TABLE EMPLEADOS(
Id_empleado INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (25),
Apelllido VARCHAR (25),
Tipo_empleo VARCHAR(35),
Codigo INT NOT NULL
);
Select * from EMPLEADOS


CREATE TABLE CUENTAS_AC(
Id_usuarios INT NOT NULL PRIMARY KEY,
Nombre_usuario VARCHAR (25),
Contraseña VARCHAR (50)NOT NULL,
Id_tipo INT
);

select * from CUENTAS_AC

CREATE TABLE ID_EN_USO(
Id INT NOT NULL PRIMARY KEY);


Select * from ID_EN_USO

INSERT INTO ID_EN_USO VALUES (1)
INSERT INTO ID_EN_USO VALUES (2)
INSERT INTO ID_EN_USO VALUES (3)