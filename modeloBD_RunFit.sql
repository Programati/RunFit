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

-- Crear tabla PRODUCTOS
DROP TABLE PRODUCTOS (
    id_producto INT IDENTITY(1,1) NOT NULL,
    detalle_producto VARCHAR(100) NULL,
    nombre_producto VARCHAR(10) NOT NULL,
    precio_compra FLOAT NOT NULL,
    stock INT NOT NULL,
    stock_minimo INT NOT NULL,
    imagen VARCHAR(255) NULL,
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
    importe_total INT NOT NULL,
    fecha_factura DATE NOT NULL default getdate(),
    id_usuario INT NOT NULL,
    CONSTRAINT PK_VENTAS PRIMARY KEY (id_venta),
    CONSTRAINT FK_VENTAS_USUARIOS FOREIGN KEY (id_usuario) REFERENCES USUARIOS(id_usuario)
);
GO

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


--Prodcedimientos almacenados
--REGISTRAR PERSONA
 CREATE PROC SP_REGISTRARPERSONA(
    @dni VARCHAR(20),
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @email VARCHAR(80),
    @telefono VARCHAR(30),
    @fecha_nacimiento DATE,
    @sexo CHAR(1),
	@IdPersonaResultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @IdPersonaResultado = 0
	set @Mensaje = ''

	if not exists (SELECT * from PERSONAS WHERE dni = @dni)
	begin
		insert PERSONAS(dni,nombre,apellido,email,telefono,fecha_nacimiento,sexo) values(@dni,@nombre,@apellido,@email,@telefono,@fecha_nacimiento,@sexo)

		set @IdPersonaResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'Ya existe un usuario con el mismo número de documento'

 end
 go

  /*EDITAR PERSONA*/
  CREATE PROC SP_EDITARPERSONA(
	@id_persona int,
    @dni VARCHAR(20),
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @email VARCHAR(80),
    @telefono VARCHAR(30),
    @fecha_nacimiento DATE,
    @sexo CHAR(1),
	@Respuesta bit output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists (SELECT * from PERSONAS WHERE dni = @dni and id_persona != @id_persona)
	begin
		update PERSONAS set
		dni = @dni,
		nombre = @nombre,
		apellido = @apellido,
		email = @email,
		telefono = @telefono,
		fecha_nacimiento =@fecha_nacimiento,
		sexo = @sexo
		WHERE id_persona = @id_persona

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'Ya existe un usuario con el mismo número de documento'

 end
 go

 --/*REGISTRAR DOMICILIO*/
 CREATE PROC SP_REGISTRARDOMICILIO(
    @calle VARCHAR(50),
    @altura VARCHAR(4),
    @casa VARCHAR(4),
    @manzana VARCHAR(4),
    @departamento VARCHAR(4),
    @piso VARCHAR(4),
    @id_persona INT,
	@IdDomicilioResultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	insert DOMICILIOS(calle,altura,casa,manzana,departamento,piso,id_persona) values(@calle,@altura,@casa,@manzana,@departamento,@piso,@id_persona)
	set @IdDomicilioResultado = 1
	set @Mensaje = 'Domicilio agregado'

	set @IdDomicilioResultado = SCOPE_IDENTITY()

 end
 go

  /*EDITAR DOMICILIO*/
  CREATE PROC SP_EDITARDOMICILIO(
	@id_domicilio int,
    @calle VARCHAR(50),
    @altura VARCHAR(4),
    @casa VARCHAR(4),
    @manzana VARCHAR(4),
    @departamento VARCHAR(4),
    @piso VARCHAR(4),
    @id_persona INT,
	@Respuesta bit output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	update DOMICILIOS set
	calle = @calle,
	altura = @altura,
	casa = @casa,
	manzana = @manzana,
	departamento = @departamento,
	piso = @piso,
	id_persona = @id_persona
	WHERE id_domicilio = @id_domicilio

	set @Respuesta = 1
	set @Mensaje = 'Domicilio actualizado'
 end
 go

 /* REGISTRAR USUARIO*/
 CREATE PROC SP_REGISTRARUSUARIO(
    @nombre_usuario VARCHAR(20),
    @password VARCHAR(255),
    @id_persona INT,
    @id_rol INT,
	@IdUsuarioResultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''

	if not exists (SELECT * from USUARIOS WHERE nombre_usuario = @nombre_usuario)
	begin
		insert USUARIOS(nombre_usuario,password,id_persona,id_rol) values(@nombre_usuario,@password,@id_persona,@id_rol)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'Ya existe un EMPLEADO con el mismo nombre de usuario. Ingrese un nombre diferente'

 end
 go

 /*EDITAR USUARIO*/
 CREATE PROC SP_EDITARUSUARIO(
    @id_usuario INT,
    @nombre_usuario VARCHAR(20),
    @password VARCHAR(255),
    @id_persona INT,
    @id_rol INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT * FROM USUARIOS WHERE nombre_usuario = @nombre_usuario AND id_usuario != @id_usuario)
    BEGIN
        -- Si el password es NULL, actualiza sin modificar el campo password
        IF @password = ''
        BEGIN
            UPDATE USUARIOS 
            SET 
                nombre_usuario = @nombre_usuario,
                id_persona = @id_persona,
                id_rol = @id_rol
            WHERE id_usuario = @id_usuario
        END
        ELSE
        BEGIN
            -- Si el password NO es NULL, actualiza incluyendo el campo password
            UPDATE USUARIOS 
            SET 
                nombre_usuario = @nombre_usuario,
                password = @password,
                id_persona = @id_persona,
                id_rol = @id_rol
            WHERE id_usuario = @id_usuario
        END

        SET @Respuesta = 1
        SET @Mensaje = 'Usuario ACTUALIZADO'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Ya existe un EMPLEADO con el mismo nombre de usuario. Ingrese un nombre diferente'
    END
END
GO
 --ELIMINAR USUARIO
 CREATE PROC SP_ELIMINARUSUARIO
(
    @id_usuario INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si el usuario existe
    IF EXISTS (SELECT 1 FROM Usuarios WHERE id_usuario = @id_usuario)
    BEGIN
        DECLARE @fecha_baja_actual DATE;
        SELECT @fecha_baja_actual = fecha_baja FROM Usuarios WHERE id_usuario = @id_usuario;

        -- Si la fecha de baja es NULL, la actualiza con la fecha actual
        IF @fecha_baja_actual IS NULL
        BEGIN
            UPDATE Usuarios
            SET fecha_baja = CAST(GETDATE() AS DATE)
            WHERE id_usuario = @id_usuario;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si la fecha de baja no es NULL, la pone a NULL
            UPDATE Usuarios
            SET fecha_baja = NULL
            WHERE id_usuario = @id_usuario;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el usuario no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'El usuario no existe.';
    END
END

CREATE PROC SP_ELIMINAR_PERSONA
(
    @id_persona INT,
	@Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si el usuario existe
    IF EXISTS (SELECT 1 FROM PERSONAS WHERE id_persona = @id_persona)
    BEGIN
        DECLARE @estado char;
        SELECT @estado = estado FROM PERSONAS WHERE id_persona = @id_persona;

        -- Si el cliente es 1 cambia a 0
        IF @estado=1
        BEGIN
            UPDATE PERSONAS
            SET estado = 0
            WHERE id_persona = @id_persona;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si el cliente es 0 cambia a 1
            UPDATE PERSONAS
            SET estado = 1
            WHERE id_persona = @id_persona;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el usuario no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'El Cliente no existe.';
    END
END

--REGISTRAR CATEGORIAS
CREATE PROC SP_REGISTRARCATEGORIAS
(
    @nombre_categoria VARCHAR(20),
	@Resultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE nombre_categoria = @nombre_categoria)
	begin
		insert into CATEGORIAS(nombre_categoria)values(@nombre_categoria)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'La categoria ' + @nombre_categoria + ' ya existe!'
end
go

--EDITAR CATEGORIAS
CREATE PROC SP_EDITARCATEGORIAS
(
	@id_categoria INT,
    @nombre_categoria VARCHAR(20),
	@Resultado bit output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE nombre_categoria = @nombre_categoria and id_categoria != @id_categoria)
		begin
			update CATEGORIAS set
			nombre_categoria = @nombre_categoria
			WHERE id_categoria = @id_categoria
			set @Resultado = SCOPE_IDENTITY()
			set @Mensaje = 'Edición existosa!'
		end
	else
		begin
			set @Resultado = 0
			set @Mensaje = 'La categoria ' + @nombre_categoria + ' ya existe!'
		end
end
go

CREATE PROC SP_ELIMINARPERSONA
(
    @id_persona INT,
    @Respuesta CHAR(1) OUTPUT,  -- Cambié el tamaño a CHAR(1)
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Inicializar @Respuesta
    SET @Respuesta = '0';

    -- Verifica si la persona existe
    IF EXISTS (SELECT 1 FROM PERSONAS WHERE id_persona = @id_persona)
    BEGIN
        DECLARE @estado_actual CHAR(1);  -- Cambié el tamaño a CHAR(1)
        SELECT @estado_actual = estado FROM PERSONAS WHERE id_persona = @id_persona;

        -- Si el estado es '1' (activo), lo cambia a '0' (inactivo)
        IF @estado_actual = '1'
        BEGIN
            UPDATE PERSONAS
            SET estado = '0'
            WHERE id_persona = @id_persona;

            SET @Respuesta = '1'; -- Estado cambiado a activo (1)
            SET @Mensaje = 'El estado se ha cambiado a activo.';
        END
        ELSE
        BEGIN
            -- Si el estado es '0' (inactivo), lo cambia a '1' (activo)
            UPDATE PERSONAS
            SET estado = '1'
            WHERE id_persona = @id_persona;

            SET @Respuesta = '0'; -- Estado cambiado a inactivo (0)
            SET @Mensaje = 'El estado se ha cambiado a inactivo.';
        END
    END
    ELSE
    BEGIN
        -- Si la persona no existe, devuelve un mensaje de error
        SET @Respuesta = '0';
        SET @Mensaje = 'La persona no existe.';
    END
END



--REGISTRAR MARCAS
CREATE PROC SP_REGISTRARMARCAS
(
    @nombre VARCHAR(20),
	@Resultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Resultado = 0
	IF NOT EXISTS (SELECT * FROM MARCAS WHERE nombre = @nombre)
	begin
		insert into MARCAS(nombre)values(@nombre)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'La marca ' + @nombre + ' ya existe!'
end
go



--EDITAR MARCAS
CREATE PROC SP_EDITARMARCAS
(
	@id_marca INT,
    @nombre VARCHAR(20),
	@Resultado bit output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Resultado = 1
	IF NOT EXISTS (SELECT * FROM MARCAS WHERE nombre = @nombre and id_marca != @id_marca)
		begin
			update MARCAS set
			nombre = @nombre
			WHERE id_marca = @id_marca
			set @Resultado = SCOPE_IDENTITY()
			set @Mensaje = 'Edición existosa!'
		end
	else
		begin
			set @Resultado = 0
			set @Mensaje = 'La marca ' + @nombre + ' ya existe!'
		end
end
go


CREATE PROCEDURE SP_AGREGARPROVEEDOR
(
    @razon_social VARCHAR(50),
    @cuit VARCHAR(11),
    @descripcion VARCHAR(80) = NULL,
    @direccion VARCHAR(100) = NULL,
    @telefono VARCHAR(10),
    @email VARCHAR(100),
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0

    -- Verificamos si ya existe un proveedor con el mismo CUIT
    IF EXISTS (SELECT * FROM PROVEEDORES WHERE cuit = @cuit)
    BEGIN
        SET @Mensaje = 'El proveedor con CUIT ' + @cuit + ' ya existe!'
        RETURN
    END

    -- Verificamos si ya existe un proveedor con la misma razón social
    IF EXISTS (SELECT * FROM PROVEEDORES WHERE razon_social = @razon_social)
    BEGIN
        SET @Mensaje = 'El proveedor con la razón social "' + @razon_social + '" ya existe!'
        RETURN
    END

    -- Verificamos si ya existe un proveedor con el mismo email
    IF EXISTS (SELECT * FROM PROVEEDORES WHERE email = @email)
    BEGIN
        SET @Mensaje = 'El proveedor con el email "' + @email + '" ya existe!'
        RETURN
    END

    -- Si ninguna de las verificaciones falla, insertamos el nuevo proveedor
    INSERT INTO PROVEEDORES (razon_social, cuit, descripcion, fecha_alta, fecha_baja, direccion, telefono, email)
    VALUES (@razon_social, @cuit, @descripcion, GETDATE(), NULL, @direccion, @telefono, @email)

    -- Obtenemos el ID del proveedor recién insertado
    SET @Resultado = SCOPE_IDENTITY()
    SET @Mensaje = 'Proveedor agregado exitosamente.'
END
GO

GO

select * from PROVEEDORES
CREATE PROC SP_EDITARPROVEEDOR
(
	@id_Proveedor INT,
    @cuit VARCHAR(11),
    @razon_social VARCHAR(50),
    @descripcion VARCHAR(80),
    @direccion VARCHAR(100),
    @telefono VARCHAR(10),
    @email VARCHAR(100), 
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 1
    SET @Mensaje = ''  

	IF EXISTS (SELECT * FROM PROVEEDORES WHERE cuit = @cuit and id_proveedor != @id_Proveedor)
		BEGIN
				SET @Respuesta = 0  -- Indica que la actualización fue exitosa
				SET @Mensaje = 'Ya existe otro PROVEEDOR con el mismo CUIT'
			END
	ELSE IF EXISTS (SELECT * FROM PROVEEDORES WHERE razon_social = @razon_social and id_proveedor != @id_Proveedor)
		BEGIN
				SET @Respuesta = 0  -- Indica que la actualización fue exitosa
				SET @Mensaje = 'Ya existe otro PROVEEDOR con la misma Razon Social'
			END
	ELSE IF EXISTS (SELECT * FROM PROVEEDORES WHERE email = @email and id_proveedor != @id_Proveedor)
		BEGIN
				SET @Respuesta = 0  -- Indica que la actualización fue exitosa
				SET @Mensaje = 'Ya existe otro PROVEEDOR con el mismo Email'
			END
	ELSE IF EXISTS (SELECT * FROM PROVEEDORES WHERE telefono = @telefono and id_proveedor != @id_Proveedor)
		BEGIN
				SET @Respuesta = 0  -- Indica que la actualización fue exitosa
				SET @Mensaje = 'Ya existe otro PROVEEDOR con el mismo N° de telefono'
			END
	ELSE
		BEGIN
			UPDATE PROVEEDORES 
			SET 
				razon_social = @razon_social,
				cuit = @cuit,
				descripcion = @descripcion,
				direccion = @direccion,
				telefono = @telefono,
				email = @email
			WHERE id_proveedor = @id_Proveedor
			SET @Respuesta = 1
			SET @Mensaje = 'Proveedor actualizado exitosamente.'
		END
END
GO

CREATE PROC SP_ELIMINAR_PROVEEDOR
(
    @id_proveedor INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si el usuario existe
    IF EXISTS (SELECT 1 FROM PROVEEDORES WHERE id_proveedor = @id_proveedor)
    BEGIN
        DECLARE @fecha_baja_actual DATE;
        SELECT @fecha_baja_actual = fecha_baja FROM PROVEEDORES WHERE id_proveedor = @id_proveedor;

        -- Si la fecha de baja es NULL, la actualiza con la fecha actual
        IF @fecha_baja_actual IS NULL
        BEGIN
            UPDATE PROVEEDORES
            SET fecha_baja = CAST(GETDATE() AS DATE)
            WHERE id_proveedor = @id_proveedor;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si la fecha de baja no es NULL, la pone a NULL
            UPDATE PROVEEDORES
            SET fecha_baja = NULL
            WHERE id_proveedor = @id_proveedor;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el usuario no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'El proveedor no existe.';
    END
END


-- PRUEBAS DE LOS PROCEDIMIENTOS
	/*REGISTRAR PERSONA*/
 declare @idpersonagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_REGISTRARPERSONA '20789456','test1','De Prueba','test@gmail.com','3794030345','2000-01-01','M', @idpersonagenerada output, @mensajegenerado output
 
 select @idpersonagenerada
 select @mensajegenerado
 GO

 /*EDITAR PERSONA*/
 declare @Respuesta int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARPERSONA 5,'35682527','testeo del5','De Prueba','test@gmail.com','3794030345','2000-01-01','M', @Respuesta output, @mensajegenerado output
 
 select @Respuesta
 select @mensajegenerado
 select * from PERSONAS
 GO

 /*REGISTRAR DOMICILIO*/
 declare @iddomiciliogenerado int
 declare @mensajegenerado varchar(500)
 exec SP_REGISTRARDOMICILIO 'Pedro de Esnaola','5590','','','','',5, @iddomiciliogenerado output, @mensajegenerado output
 
 select @iddomiciliogenerado
 select @mensajegenerado
 SELECT * FROM DOMICILIOS

 GO

 /*EDITAR DOMICILIO*/
 declare @Respuesta int
 declare @mensajegenerado varchar(500)
 exec SP_EDITARDOMICILIO 2,'Pedro de Esnaola','5590','','','12','2',5, @Respuesta output, @mensajegenerado output
 
 select @Respuesta
 select @mensajegenerado
 SELECT * FROM DOMICILIOS

 GO

/*REGISTRAR CATEGORIAS*/
 declare @idcategoriagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_REGISTRARCATEGORIAS'MEDIAS', @idcategoriagenerada output, @mensajegenerado output
 
 select @idcategoriagenerada
 select @mensajegenerado
 GO

 /*EDITAR CATEGORIAS*/
 declare @idcategoriagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARCATEGORIAS 2,'ZAPATILLAS', @idcategoriagenerada output, @mensajegenerado output
 
 select @idcategoriagenerada
 select @mensajegenerado
 GO

 /*REGISTRAR MARCAS*/
 declare @idmarcagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_REGISTRARMARCAS 'TOPPER', @idmarcagenerada output, @mensajegenerado output
 
 select @idmarcagenerada
 select @mensajegenerado
 GO

 /*EDITAR CATEGORIAS*/
 declare @idmarcagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARMARCAS 2,'TOPPER', @idmarcagenerada output, @mensajegenerado output
 
 select @idmarcagenerada
 select @mensajegenerado
 GO

 /*EDITAR USUARIO*/
 declare @idusuariogenerado int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARUSUARIO 3,'ROMINA',NULL,3,3, @idusuariogenerado output, @mensajegenerado output
 select @idusuariogenerado
 select @mensajegenerado
 GO
 SELECT * FROM USUARIOS
 select * from PERSONAS
 select * from DOMICILIOS

 update personas
 set estado=1 where id_persona=5

 SELECT d.id_domicilio, d.calle, d.altura, d.casa, d.manzana, d.departamento, d.piso, d.id_persona, p.dni, p.nombre, p.apellido, p.email, p.telefono, p.fecha_nacimiento, p.sexo,p.estado FROM DOMICILIOS d
                   inner join PERSONAS p on p.id_persona = d.id_persona
                    WHERE d.id_persona = p.id_persona
                    order by p.estado desc
GO
select * from PROVEEDORES


/*EDITAR proveedores*/
 declare @idProveedor int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARPROVEEDOR 3, '30124578913','Juanito3', 'Zapas', 'Av. 9 de Julio', '3794564513', 'Juanito3@gmail.com', @idProveedor output, @mensajegenerado output
 
 select @idProveedor
 select @mensajegenerado
 GO
 select * from PROVEEDORES