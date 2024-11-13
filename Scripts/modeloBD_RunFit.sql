create database RunFit
create database Corre

use  Runfit



-- Eliminar tablas si ya existen
IF OBJECT_ID('DETALLE_VENTAS', 'U') IS NOT NULL DROP TABLE DETALLE_VENTAS;
IF OBJECT_ID('VENTAS', 'U') IS NOT NULL DROP TABLE VENTAS;
IF OBJECT_ID('USUARIOS', 'U') IS NOT NULL DROP TABLE USUARIOS;
IF OBJECT_ID('PRODUCTOS', 'U') IS NOT NULL DROP TABLE PRODUCTOS;
IF OBJECT_ID('PROVEEDORES', 'U') IS NOT NULL DROP TABLE PROVEEDORES;
IF OBJECT_ID('PERSONAS', 'U') IS NOT NULL DROP TABLE PERSONAS;
IF OBJECT_ID('DOMICILIOS', 'U') IS NOT NULL DROP TABLE DOMICILIOS;
IF OBJECT_ID('CATEGORIAS', 'U') IS NOT NULL DROP TABLE CATEGORIAS;
IF OBJECT_ID('MARCAS', 'U') IS NOT NULL DROP TABLE MARCAS;
IF OBJECT_ID('ROL', 'U') IS NOT NULL DROP TABLE ROL;
GO

-- Crear tabla ROL
CREATE TABLE ROL (
    id_rol INT IDENTITY(1,1) NOT NULL,
    nombre_rol VARCHAR(20) NOT NULL,
    fecha_alta DATE NOT NULL default getdate(),
    fecha_baja DATE NULL,
    CONSTRAINT PK_ROL PRIMARY KEY (id_rol)
);
GO

-- Crear tabla PERSONAS
CREATE TABLE PERSONAS (
    id_persona INT IDENTITY(1,1) NOT NULL,
    dni VARCHAR(20) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    email VARCHAR(80) NOT NULL,
    telefono VARCHAR(30) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    sexo CHAR(1) NOT NULL,
    estado CHAR(1) NOT NULL DEFAULT '1', -- Campo estado de tipo CHAR(1) con valor por defecto '1'
    CONSTRAINT PK_PERSONAS PRIMARY KEY (id_persona)
);

GO
CREATE TABLE BackupList (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    BackupFileName NVARCHAR(255),
    BackupDate DATETIME
);

-- Crear tabla PROVEEDORES
CREATE TABLE PROVEEDORES (
    id_proveedor INT IDENTITY(1,1) NOT NULL,
    razon_social VARCHAR(50) NOT NULL,
    cuit VARCHAR(11) NOT NULL,
    descripcion VARCHAR(80) NULL,
    fecha_alta DATE NOT NULL DEFAULT GETDATE(),
    fecha_baja DATE NULL,
    direccion VARCHAR(100) NULL,
    telefono VARCHAR(10) NOT NULL,
    email VARCHAR(100) NULL,  -- Nuevo campo para el email
    CONSTRAINT PK_PROVEEDORES PRIMARY KEY (id_proveedor)
);
GO

-- Crear tabla MARCAS
CREATE TABLE MARCAS (
    id_marca INT IDENTITY(1,1) NOT NULL,
    nombre VARCHAR(20) NOT NULL,
    fecha_alta DATE NOT NULL default getdate(),
    fecha_baja DATE NULL,
    CONSTRAINT PK_MARCAS PRIMARY KEY (id_marca)
);
GO

-- Crear tabla CATEGORIAS
CREATE TABLE CATEGORIAS (
    id_categoria INT IDENTITY(1,1) NOT NULL,
    nombre_categoria VARCHAR(20) NOT NULL,
    fecha_alta DATE NOT NULL default getdate(),
    fecha_baja DATE NULL,
    CONSTRAINT PK_CATEGORIAS PRIMARY KEY (id_categoria)
);
GO

-- Crear tabla PRODUCTOS
CREATE TABLE PRODUCTOS (
    id_producto INT IDENTITY(1,1) NOT NULL,
    detalle_producto VARCHAR(100) NULL,
    nombre_producto VARCHAR(100) NOT NULL,
    precio_compra FLOAT NOT NULL,
	precio_venta FLOAT NOT NULL,
    stock INT NOT NULL,
    stock_minimo INT NOT NULL,
    imagen varbinary(MAX) NULL,
    fecha_alta DATE NOT NULL default getdate(),
    fecha_baja DATE NULL,
    id_marca INT NOT NULL,
    id_categoria INT NOT NULL,
    id_proveedor INT NOT NULL,
    CONSTRAINT PK_PRODUCTOS PRIMARY KEY (id_producto),
    CONSTRAINT FK_PRODUCTOS_MARCAS FOREIGN KEY (id_marca) REFERENCES MARCAS(id_marca),
    CONSTRAINT FK_PRODUCTOS_CATEGORIAS FOREIGN KEY (id_categoria) REFERENCES CATEGORIAS(id_categoria),
    CONSTRAINT FK_PRODUCTOS_PROVEEDORES FOREIGN KEY (id_proveedor) REFERENCES PROVEEDORES(id_proveedor)
);
GO

-- Crear tabla DOMICILIOS
CREATE TABLE DOMICILIOS (
    id_domicilio INT IDENTITY(1,1) NOT NULL,
    calle VARCHAR(50) NOT NULL,
    altura VARCHAR(4) NULL,
    casa VARCHAR(4) NULL,
    manzana VARCHAR(4) NULL,
    departamento VARCHAR(4) NULL,
    piso VARCHAR(4) NULL,
    id_persona INT NOT NULL,
    CONSTRAINT PK_DOMICILIOS PRIMARY KEY (id_domicilio),
    CONSTRAINT FK_DOMICILIOS_PERSONAS FOREIGN KEY (id_persona) REFERENCES PERSONAS(id_persona)
);
GO

-- Crear tabla USUARIOS
CREATE TABLE USUARIOS (
    id_usuario INT IDENTITY(1,1) NOT NULL,
    nombre_usuario VARCHAR(20) NOT NULL,
    password VARCHAR(255) NOT NULL,
    fecha_alta DATE NOT NULL default getdate(),
    fecha_baja DATE NULL,
    id_persona INT NOT NULL,
    id_rol INT NOT NULL,
    CONSTRAINT PK_USUARIOS PRIMARY KEY (id_usuario),
    CONSTRAINT FK_USUARIOS_PERSONAS FOREIGN KEY (id_persona) REFERENCES PERSONAS(id_persona),
    CONSTRAINT FK_USUARIOS_ROL FOREIGN KEY (id_rol) REFERENCES ROL(id_rol)
);
GO

-- Crear tabla VENTAS
CREATE TABLE VENTAS (
    id_venta INT IDENTITY(1,1) NOT NULL,
    importe_total DECIMAL(18, 2) NOT NULL,
    fecha_factura DATE NOT NULL default getdate(),
    id_usuario INT NOT NULL,
	id_cliente INT NOT NULL,
    CONSTRAINT PK_VENTAS PRIMARY KEY (id_venta),
    CONSTRAINT FK_VENTAS_USUARIOS FOREIGN KEY (id_usuario) REFERENCES USUARIOS(id_usuario),
	CONSTRAINT FK_VENTAS_PERSONAS FOREIGN KEY (id_cliente) REFERENCES PERSONAS(id_persona)
);
GO

-- Crear tabla DETALLE_VENTAS
CREATE TABLE DETALLE_VENTAS (
    id_detalleFactura INT IDENTITY(1,1) NOT NULL,
    cantidad INT NOT NULL,
    subtotal DECIMAL(18, 2) NOT NULL,
    id_producto INT NOT NULL,
    id_venta INT NOT NULL,
    CONSTRAINT PK_DETALLE_VENTAS PRIMARY KEY (id_detalleFactura),
    CONSTRAINT FK_DETALLE_VENTAS_PRODUCTOS FOREIGN KEY (id_producto) REFERENCES PRODUCTOS(id_producto),
    CONSTRAINT FK_DETALLE_VENTAS_VENTAS FOREIGN KEY (id_venta) REFERENCES VENTAS(id_venta)
);
GO

/*
insert ROL(nombre_rol) VALUES('Sistema');
insert ROL(nombre_rol) VALUES('Gerente');
insert ROL(nombre_rol) VALUES('Vendedor');

insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('35682527', 'Matias Jose', 'Martinez', 'mati@gmail.com', '3704646563', '1994-06-12','M');
insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('49129901', 'Ramiro Andres', 'Lopez', 'ramiro@gmail.com', '3794734982', '2000-09-12','M');
insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('43129901', 'Noelia Cecilia', 'Canepa', 'noelia@gmail.com', '3794378496', '2002-02-23','F');

insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('matias', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1,1);
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('ramiro', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 2,2);
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('noelia', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 3,3);
*/