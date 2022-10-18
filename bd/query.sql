--Ejecutar 1
CREATE DATABASE PPI
GO
--Ejecutar 2
USE PPI

--Ejecutar 3

CREATE TABLE localidades(
	id_localidad INT PRIMARY KEY identity,
	codigo_postal nvarchar(20),
	nombre_localidad nvarchar(80)
)

CREATE TABLE usuarios(
	id_usuario INT PRIMARY KEY identity,
	nombre nvarchar(60),
	apellido nvarchar(60),
	cuit NVARCHAR(18) UNIQUE,
	contrasena NVARCHAR(120),
	fecha_nacimiento date,
	direccion nvarchar(120),
	localidad INT FOREIGN KEY REFERENCES localidades(id_localidad),
	correo_electronico NVARCHAR(160) UNIQUE,
	correo_verificado TINYINT DEFAULT 0,
	rol TINYINT DEFAULT 0
)

CREATE TABLE estados(
	id_estado INT PRIMARY KEY identity,
	nombre NVARCHAR(60)
)

CREATE TABLE proyectos(
	id_proyecto INT PRIMARY KEY identity,
	titulo nvarchar(120),
	descripcion TEXT,
	fecha datetime2,
	monto FLOAT,
	id_estado INT FOREIGN KEY REFERENCES estados(id_estado)
)

CREATE TABLE votos_proyectos(
	id_voto INT PRIMARY KEY identity,
	id_proyecto INT FOREIGN KEY REFERENCES proyectos(id_proyecto),
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario),
	votos_favor INT DEFAULT 0,
	votos_contra INT DEFAULT 0
)

CREATE TABLE comentarios(
	id_comentario INT PRIMARY KEY identity,
	id_proyecto INT FOREIGN KEY REFERENCES proyectos(id_proyecto),
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario),
	comentario TEXT,
)

CREATE TABLE votos_comentarios(
	id_voto_comentario INT PRIMARY KEY identity,
	id_comentario INT FOREIGN KEY REFERENCES comentarios(id_comentario),
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario),
	si_gusta INT DEFAULT 0,
	no_gusta INT DEFAULT 0
)

CREATE TABLE comentarios_respuestas(
	id_comentario_respuesta INT PRIMARY KEY identity,
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario),
	id_comentario INT FOREIGN KEY REFERENCES comentarios(id_comentario),
	respuesta TEXT
)

INSERT INTO estados (nombre)
VALUES ('Aprobado'),
('En votación')

INSERT INTO LOCALIDADES (codigo_postal, nombre_localidad)
VALUES ('2000', 'Rosario')

SELECT c.id_comentario, c.comentario, CONCAT(u.nombre, ' ', u.apellido) AS usuario_nombre
          FROM comentarios AS c
          INNER JOIN usuarios AS u ON c.id_usuario = u.id_usuario

select count(*) from votos_comentarios

SELECT
	coalesce(sum(si_gusta), 0) AS MeGusta,
	coalesce(sum(no_gusta), 0) AS NoMeGusta
  FROM votos_comentarios

	SELECT c.respuesta, CONCAT(u.nombre, ' ', u.apellido) AS usuario_nombre
          FROM comentarios_respuestas AS c
          INNER JOIN usuarios AS u ON c.id_usuario = u.id_usuario

select * from usuarios
update usuarios set rol = 3 where id_usuario = 1