create database AUTOBUSES
use AUTOBUSES

create table choferes (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(40) NOT NULL,
APELLIDO VARCHAR(40) NOT NULL,
FECHA_DE_NACIMIENTO VARCHAR(40) NOT NULL,
CEDULA VARCHAR(40) NOT NULL
);

create table autobuses (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
MARCA VARCHAR(40) NOT NULL,
MODELO VARCHAR(40) NOT NULL,
PLACA VARCHAR(40) NOT NULL,
COLOR VARCHAR(40),
AÑO VARCHAR(40) 
);

create table rutas (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
RUTA VARCHAR(40) NOT NULL,
);

create table asignacion (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
CHOFER VARCHAR(40),
AUTOBUS VARCHAR(40),
RUTA VARCHAR(40)
);


SELECT * FROM asignacion
SELECT * FROM choferes
SELECT * FROM rutas
SELECT * FROM autobuses

DROP TABLE choferes
DROP TABLE rutas
DROP TABLE autobuses
DROP TABLE asignacion

update asignacion set CHOFER= 'Carlos' where Id=01
delete from rutas where Id=4
delete from choferes where Id=4
delete from autobuses where Id=4

insert into choferes values('Juan','Perez','11/10/90','40228724197')
insert into autobuses values('VOLVO','Z50','A019865','Negro','1990')
insert into rutas values('Los minas')
insert into asignacion values('1','1','3')




SELECT IdRUTA FROM asignacion
GROUP BY IdRUTA 
HAVING COUNT (*)>1;
     







DROP TABLE choferes
DROP TABLE rutas
DROP TABLE autobuses
DROP TABLE asignacion