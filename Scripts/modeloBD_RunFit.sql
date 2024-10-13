create database RunFit

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


 -- Agregar el nuevo campo para el email

select * from PROVEEDORES
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
ALTER TABLE PRODUCTOS
ALTER COLUMN nombre_producto VARCHAR(100) NOT NULL;

-- Crear tabla PRODUCTOS
<<<<<<< HEAD
create TABLE PRODUCTOS (
=======
CREATE TABLE PRODUCTOS (
>>>>>>> 767f9c1599ad3420d792e81cfd0e2c2d56764876
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
/* pasos para el campo IMAGEN
ALTER TABLE productos
ADD imagen_temp varbinary(MAX);

UPDATE productos
SET imagen_temp = CONVERT(varbinary(MAX), imagen);

ALTER TABLE productos
DROP COLUMN imagen;

EXEC sp_rename 'productos.imagen_temp', 'imagen', 'COLUMN';
SELECT * FROM PRODUCTOS

*/
delete from PRODUCTOS where id_producto=9

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
    importe_total INT NOT NULL,
    fecha_factura DATE NOT NULL default getdate(),
    id_usuario INT NOT NULL,
    CONSTRAINT PK_VENTAS PRIMARY KEY (id_venta),
    CONSTRAINT FK_VENTAS_USUARIOS FOREIGN KEY (id_usuario) REFERENCES USUARIOS(id_usuario)
);
GO
/*
ALTER TABLE VENTAS
ADD id_cliente INT NOT NULL;

ALTER TABLE VENTAS
ADD CONSTRAINT FK_VENTAS_PERSONAS FOREIGN KEY (id_cliente) REFERENCES PERSONAS(id_persona);

ALTER TABLE VENTAS
ALTER COLUMN importe_total DECIMAL(18, 2);

*/

-- Crear tabla DETALLE_VENTAS
CREATE TABLE DETALLE_VENTAS (
    id_detalleFactura INT IDENTITY(1,1) NOT NULL,
    cantidad INT NOT NULL,
    subtotal FLOAT NOT NULL,
    id_producto INT NOT NULL,
    id_venta INT NOT NULL,
    CONSTRAINT PK_DETALLE_VENTAS PRIMARY KEY (id_detalleFactura),
    CONSTRAINT FK_DETALLE_VENTAS_PRODUCTOS FOREIGN KEY (id_producto) REFERENCES PRODUCTOS(id_producto),
    CONSTRAINT FK_DETALLE_VENTAS_VENTAS FOREIGN KEY (id_venta) REFERENCES VENTAS(id_venta)
);
GO

/*
ALTER TABLE DETALLE_VENTAS
ALTER COLUMN subtotal DECIMAL(18, 2);
*/


select * from USUARIOS;
SELECT * FROM PERSONAS;
SELECT * FROM ROL;
UPDATE ROL set
nombre_rol = 'Vendedor'
WHERE id_rol = 3
/*
insert ROL(nombre_rol) VALUES('Sistema');
insert ROL(nombre_rol) VALUES('Gerente');
insert ROL(nombre_rol) VALUES('Vendedor');

insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('35682527', 'Matias Jose', 'Martinez', 'mati@gmail.com', '3704646563', '1994-06-12','M');
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('matias', '123', 1, 1);

insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('49129901', 'Ramiro Andres', 'Lopez', 'ramiro@gmail.com', '3794734982', '2000-09-12','M');
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('ramiro', '123', 2, 2);

insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('43129901', 'Noelia Cecilia', 'Canepa', 'noelia@gmail.com', '3794378496', '2002-02-23','F');
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('noelia', '123', 3, 3);

insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values('37206965', 'Julio Osvaldo', 'Cantero', 'julio@gmail.com', '3794779822', '2000-09-03','M');
insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values('julio', '123', 4,3);
*/


 GO




 update personas
 set estado=1 where id_persona=5

 SELECT d.id_domicilio, d.calle, d.altura, d.casa, d.manzana, d.departamento, d.piso, d.id_persona, p.dni, p.nombre, p.apellido, p.email, p.telefono, p.fecha_nacimiento, p.sexo,p.estado FROM DOMICILIOS d
                   inner join PERSONAS p on p.id_persona = d.id_persona
                    WHERE d.id_persona = p.id_persona
                    order by p.estado desc
GO
select * from PROVEEDORES
select * from USUARIOS


/*EDITAR proveedores*/
 declare @idProveedor int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARPROVEEDOR 3, '30124578913','Juanito3', 'Zapas', 'Av. 9 de Julio', '3794564513', 'Juanito3@gmail.com', @idProveedor output, @mensajegenerado output
 
 select @idProveedor
 select @mensajegenerado
 GO
 select * from CATEGORIAS

 INSERT INTO CATEGORIAS (nombre_categoria, fecha_alta, fecha_baja)
VALUES ('Electrónica', GETDATE(), NULL);
update  categorias
set nombre_categoria='Zapatillas hombre' where id_categoria=2
INSERT INTO CATEGORIAS (nombre_categoria, fecha_alta, fecha_baja)
VALUES ('Hogar', GETDATE(), NULL);
SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'CATEGORIAS';

INSERT INTO MARCAS (nombre, fecha_alta, fecha_baja)
VALUES ('Nike', GETDATE(), NULL);

INSERT INTO MARCAS (nombre, fecha_alta, fecha_baja)
VALUES ('Adidas', GETDATE(), NULL);

-- Insert para un producto Nike en la categoría de Zapatillas Hombre
INSERT INTO PRODUCTOS (detalle_producto, nombre_producto, precio_compra,precio_venta, stock, stock_minimo, imagen, fecha_alta, fecha_baja, id_marca, id_categoria, id_proveedor)
VALUES ('Zapatillas deportivas Nike Air Max para hombre', 'AirMax', 150.00,500, 50, 10, 'nike_airmax_hombre.jpg', GETDATE(), NULL, 1, 1, 1);

-- Insert para un producto Adidas en la categoría de Zapatillas Mujer
INSERT INTO PRODUCTOS (detalle_producto, nombre_producto, precio_compra,precio_venta, stock, stock_minimo, imagen, fecha_alta, fecha_baja, id_marca, id_categoria, id_proveedor)
VALUES ('Zapatillas deportivas Adidas Ultraboost para mujer', 'Ultraboost', 180.00,500, 30, 5, 'adidas_ultraboost_mujer.jpg', GETDATE(), NULL, 2, 2, 2);



select id_marca,nombre,fecha_alta,fecha_baja from MARCAS

select * from PRODUCTOS
select * from CATEGORIAS
select * from MARCAS
select * from PROVEEDORES

select p.id_producto,p.nombre_producto,p.precio_compra,p.stock,p.stock_minimo,p.imagen,p.id_marca,m.nombre,c.nombre_categoria,pv.razon_social from productos p
inner join MARCAS m on m.id_marca=p.id_marca
inner join CATEGORIAS c on c.id_categoria=p.id_categoria
inner join PROVEEDORES pv on pv.id_proveedor=p.id_proveedor
order by p.fecha_baja asc;


select * from VENTAS;
select * from DETALLE_VENTAS;
select id_producto, nombre_producto, stock from PRODUCTOS
where id_producto = 3
select id_producto, nombre_producto, stock from PRODUCTOS
where id_producto = 11

select nombre, dni from PERSONAS
join DOMICILIOS on DOMICILIOS.id_persona = PERSONAS.id_persona


delete from VENTAS where id_venta = 5

update PRODUCTOS
SET imagen = null
where id_producto > 0

SELECT 
    backupset.database_name AS DatabaseName, -- El nombre de la base de datos respaldada
    backupset.backup_start_date AS BackupStartDate, -- Fecha de inicio del respaldo
    backupset.backup_finish_date AS BackupFinishDate, -- Fecha de finalización
    backupset.backup_type AS BackupType, -- El tipo de respaldo
    CASE backupset.backup_type
        WHEN 'D' THEN 'Full Backup'
        WHEN 'I' THEN 'Differential Backup'
        WHEN 'L' THEN 'Transaction Log Backup'
        ELSE 'Other Backup Type'
    END AS BackupTypeDescription, -- Descripción legible del tipo de respaldo
    backupmediafamily.physical_device_name AS BackupLocation -- Ruta física del archivo de respaldo
FROM 
    msdb.dbo.backupset -- Tabla que almacena información de los respaldos
JOIN 
    msdb.dbo.backupmediafamily ON backupset.media_set_id = backupmediafamily.media_set_id -- Tabla que almacena las rutas
WHERE 
    backupset.database_name = 'RunFit' -- Filtrar por la base de datos que te interesa
ORDER BY 
    backupset.backup_start_date DESC; -- Ordenar los resultados por fecha de inicio de respaldo




SELECT 
    backupset.database_name AS DatabaseName,
    backupset.backup_start_date AS BackupStartDate,
    backupset.backup_finish_date AS BackupFinishDate,
    CASE backupset.type
        WHEN 'D' THEN 'Full Backup'
        WHEN 'I' THEN 'Differential Backup'
        WHEN 'L' THEN 'Transaction Log Backup'
        ELSE 'Other Backup Type'
    END AS BackupTypeDescription,
    backupmediafamily.physical_device_name AS BackupLocation
FROM 
    msdb.dbo.backupset AS backupset
INNER JOIN 
    msdb.dbo.backupmediafamily AS backupmediafamily
ON 
    backupset.media_set_id = backupmediafamily.media_set_id
WHERE 
    backupset.database_name = 'RunFit'
ORDER BY 
    backupset.backup_finish_date DESC;



	SELECT MAX(BackupStartDate) 
FROM (
    SELECT 
        backupset.backup_start_date AS BackupStartDate
    FROM 
        msdb.dbo.backupset AS backupset
    INNER JOIN 
        msdb.dbo.backupmediafamily AS backupmediafamily
    ON 
        backupset.media_set_id = backupmediafamily.media_set_id
    WHERE 
        backupset.database_name = 'RunFit'
) AS BackupDates;
