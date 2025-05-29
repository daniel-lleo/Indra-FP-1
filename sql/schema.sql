CREATE DATABASE IF NOT EXISTS sostenibilidad;
USE sostenibilidad;

CREATE TABLE usuarios (
id INT PRIMARY KEY,
nombre VARCHAR(25) NOT NULL,
correo VARCHAR(25) NOT NULL,
contrasenya VARCHAR(25) NOT NULL
);

CREATE TABLE organizadores (
id INT PRIMARY KEY,
nombre VARCHAR(25) NOT NULL,
correo VARCHAR(25) NOT NULL,
clave_acceso VARCHAR(25) NOT NULL
);

CREATE TABLE categorias (
id INT PRIMARY KEY,
nombre VARCHAR(25) NOT NULL,
descripcion VARCHAR(150)
);

CREATE TABLE ubicaciones (
id INT PRIMARY KEY,
ciudad VARCHAR(25) NOT NULL,
calle VARCHAR(25) NOT NULL
);

CREATE TABLE eventos (
id INT PRIMARY KEY,
nombre VARCHAR(25) NOT NULL,
fecha DATE NOT NULL,
duracion DECIMAL NOT NULL,
id_organizador INT,
id_categoria INT,
id_ubicacion INT,
FOREIGN KEY (id_organizador) REFERENCES organizadores (id),
FOREIGN KEY (id_categoria) REFERENCES categorias (id),
FOREIGN KEY (id_ubicacion) REFERENCES ubicaciones (id)
);

CREATE TABLE inscripciones (
id_usuario INT,
id_evento INT,
PRIMARY KEY (id_usuario, id_evento),
FOREIGN KEY (id_usuario) REFERENCES usuarios (id),
FOREIGN KEY (id_evento) REFERENCES eventos (id)
);

CREATE TABLE organizador_evento (
id_organizador INT,
id_evento INT,
PRIMARY KEY (id_organizador, id_evento),
FOREIGN KEY (id_organizador) REFERENCES organizador (id),
FOREIGN KEY (id_evento) REFERENCES eventos (id)
);