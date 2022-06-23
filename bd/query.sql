DROP DATABASE PPI
--Ejecutar primero
CREATE DATABASE PPI
--Ejecutar luego del primero para seleccionarla
USE PPI

--Ejecutar segundo
CREATE TABLE localidades(
	id_localidad INT PRIMARY KEY IDENTITY,
	codigo_postal nvarchar(10),
	nombre_localidad nvarchar(80)
)

CREATE TABLE usuarios(
	id_usuario INT PRIMARY KEY IDENTITY,
	cuit NVARCHAR(18) UNIQUE NOT NULL,
	nombre nvarchar(60) NOT NULL,
	apellido nvarchar(60) NOT NULL,
	contrasena NVARCHAR(120) NOT NULL,
	fecha_nacimiento date NOT NULL,
	direccion nvarchar(120) NOT NULL,
	id_localidad INT FOREIGN KEY REFERENCES localidades(id_localidad) NOT NULL,
	correo_electronico NVARCHAR(160) UNIQUE NOT NULL,
	rol TINYINT DEFAULT 0
)

CREATE TABLE estados(
	id_estado INT PRIMARY KEY IDENTITY,
	nombre NVARCHAR(60) NOT NULL
)

CREATE TABLE proyectos(
	id_proyecto INT PRIMARY KEY IDENTITY,
	titulo nvarchar(120) NOT NULL,
	descripcion TEXT NOT NULL,
	fecha date NOT NULL,
	monto DECIMAL(18, 2) NOT NULL,
	id_estado INT FOREIGN KEY REFERENCES estados(id_estado) NOT NULL
)

CREATE TABLE votos_proyectos(
	id_voto INT IDENTITY,
	id_proyecto INT FOREIGN KEY REFERENCES proyectos(id_proyecto) NOT NULL,
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) NOT NULL,
	tipo_voto TINYINT NOT NULL
	PRIMARY KEY (id_voto, id_usuario)
)

CREATE TABLE comentarios(
	id_comentario INT PRIMARY KEY IDENTITY,
	id_proyecto INT FOREIGN KEY REFERENCES proyectos(id_proyecto) NOT NULL,
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) NOT NULL,
	comentario TEXT NOT NULL,
	creado DATETIME DEFAULT (sysdatetime())
)

CREATE TABLE votos_comentarios(
	id_voto_comentario INT PRIMARY KEY IDENTITY,
	id_comentario INT FOREIGN KEY REFERENCES comentarios(id_comentario) NOT NULL,
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) NOT NULL,
	tipo_voto TINYINT NOT NULL,
	tipo_comentario TINYINT NOT NULL
)

CREATE TABLE comentarios_respuestas(
	id_comentario_respuesta INT PRIMARY KEY IDENTITY,
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) NOT NULL,
	id_comentario INT FOREIGN KEY REFERENCES comentarios(id_comentario) NOT NULL,
	respuesta TEXT NOT NULL,
	creado DATETIME DEFAULT (sysdatetime())
)

-- Cantidades
SELECT COUNT(*) FROM comentarios
SELECT COUNT(*) FROM comentarios_respuestas
SELECT COUNT(*) FROM estados
SELECT COUNT(*) FROM localidades
SELECT COUNT(*) FROM proyectos
SELECT COUNT(*) FROM usuarios
SELECT COUNT(*) FROM votos_comentarios
SELECT COUNT(*) FROM votos_proyectos WHERE id_proyecto = 1 AND tipo_voto = 0

-- Ver
SELECT * FROM comentarios
SELECT * FROM comentarios_respuestas
SELECT * FROM estados
SELECT * FROM localidades
SELECT * FROM proyectos
SELECT * FROM usuarios
SELECT * FROM votos_comentarios
SELECT * FROM votos_proyectos

INSERT INTO estados (nombre)
VALUES ('Aprobado')
INSERT INTO estados (nombre)
VALUES ('En votación')

insert into proyectos (titulo, descripcion, fecha, monto, id_estado)
values ('test1', 'Por votar 1', '04/03/2022', 202020, 2)
insert into proyectos (titulo, descripcion, fecha, monto, id_estado)
values ('test2', 'Aprobado 1', '04/03/2022', 202020, 1)

INSERT INTO LOCALIDADES (codigo_postal, nombre_localidad)
VALUES ('2000', 'Rosario')
