

select * from PRODUCTOS
select * from categorias
select * from MARCAS
--Prodcedimientos almacenados
/*REGISTRAR PERSONA*/
CREATE PROC SP_PERSONA_REGISTRAR(
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
CREATE PROC SP_PERSONA_EDITAR(
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
 select * from PERSONAS
 /*ELIMINAR PERSONA*/
CREATE PROC SP_PERSONA_ELIMINAR(
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
GO

-------------------------------------------------------------
go

 /*REGISTRAR DOMICILIO*/
CREATE PROC SP_DOMICILIO_REGISTRAR(
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
GO

/*EDITAR DOMICILIO*/
CREATE PROC SP_DOMICILIO_EDITAR(
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

  --------------------------------------------------------------
 go

 /* REGISTRAR USUARIO*/
CREATE PROC SP_USUARIO_REGISTRAR(
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
CREATE PROC SP_USUARIO_EDITAR(
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
CREATE PROC SP_USUARIO_ELIMINAR(
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
GO

  --------------------------------------------------------------
 go

/*REGISTRAR CATEGORIAS*/
CREATE PROC SP_CATEGORIAS_REGISTRAR(
    @nombre_categoria VARCHAR(20),
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''
    
    IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE nombre_categoria = @nombre_categoria)
    BEGIN
        INSERT INTO CATEGORIAS(nombre_categoria, fecha_alta) 
        VALUES(@nombre_categoria, GETDATE());

        SET @Resultado = SCOPE_IDENTITY();
        SET @Mensaje = 'Categoría registrada exitosamente.';
    END
    ELSE
    BEGIN
        SET @Mensaje = 'La categoría ' + @nombre_categoria + ' ya existe!';
    END
END
GO

/*EDITAR CATEGORIAS*/
CREATE PROC SP_CATEGORIAS_EDITAR(
	@id_categoria INT,
    @nombre_categoria VARCHAR(20),
	@Respuesta BIT OUTPUT,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Respuesta = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE nombre_categoria = @nombre_categoria and id_categoria != @id_categoria)
		begin
			update CATEGORIAS set
			nombre_categoria = @nombre_categoria
			WHERE id_categoria = @id_categoria
			set @Respuesta = 1
			set @Mensaje = 'Edición existosa!'
		end
	else
		begin
			set @Respuesta = 0
			set @Mensaje = 'La categoria ' + @nombre_categoria + ' ya existe!'
		end
end
go
CREATE PROC SP_CATEGORIA_ELIMINAR(
    @id_categoria INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si la categoria existe
    IF EXISTS (SELECT 1 FROM CATEGORIAS WHERE id_categoria = @id_categoria)
    BEGIN
        DECLARE @fecha_baja_actual DATE;
        SELECT @fecha_baja_actual = fecha_baja FROM CATEGORIAS WHERE id_categoria = @id_categoria;

        -- Si la fecha de baja es NULL, la actualiza con la fecha actual
        IF @fecha_baja_actual IS NULL
        BEGIN
            UPDATE CATEGORIAS
            SET fecha_baja = CAST(GETDATE() AS DATE)
            WHERE id_categoria = @id_categoria;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si la fecha de baja no es NULL, la pone a NULL
            UPDATE CATEGORIAS
            SET fecha_baja = NULL
            WHERE id_categoria = @id_categoria;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el usuario no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'La Categoria no existe.';
    END
END
go
  --------------------------------------------------------------
 go

 /*REGISTRAR PRODUCTO*/ 
CREATE PROC SP_PRODUCTO_REGISTRAR (
    @nombre_producto VARCHAR(50),
    @precio_compra DECIMAL,
    @precio_venta DECIMAL,
    @id_marca INT,
    @id_categoria INT,
    @id_proveedor INT,
    @stock INT,
    @stock_minimo INT,
    @detalle VARCHAR(100),
    @imagen varbinary(MAX) = NULL,
    @IdProductoResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdProductoResultado = 0
    SET @Mensaje = ''

    -- Verificar si ya existe un producto con el mismo nombre y detalle
    IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE nombre_producto = @nombre_producto AND detalle_producto = @detalle)
    BEGIN
        -- Si existe un producto duplicado, enviamos un mensaje de error
        SET @Mensaje = 'Ya existe un producto con el mismo nombre y detalle.'
    END
    ELSE
    BEGIN
        -- Inserción del producto
        BEGIN TRY
            INSERT INTO PRODUCTOS (nombre_producto, precio_compra, precio_venta, id_marca, id_categoria, id_proveedor, stock, stock_minimo, detalle_producto, imagen)
            VALUES (@nombre_producto, @precio_compra, @precio_venta, @id_marca, @id_categoria, @id_proveedor, @stock, @stock_minimo, @detalle, @imagen)

            SET @IdProductoResultado = SCOPE_IDENTITY()  -- Obtener el ID del producto recién insertado
            SET @Mensaje = 'Producto agregado correctamente.'
        END TRY
        BEGIN CATCH
            SET @Mensaje = ERROR_MESSAGE()  -- Captura el error
        END CATCH
    END
END

<<<<<<< HEAD
go
select * from CATEGORIAS;
select * from PRODUCTOS
=======
>>>>>>> rama-matias
go

/*EDITAR PRODUCTO*/ 
CREATE PROC SP_PRODUCTO_EDITAR
(
    @id_producto int,
    @detalle_producto VARCHAR(100),
    @nombre_producto VARCHAR(100),
    @precio_compra float,
    @precio_venta float,
    @stock int,
    @stock_minimo int,
    @id_marca int,
    @id_categoria int,
    @id_proveedor int,
    @imagen varbinary(MAX) = NULL,
    @Respuesta bit output,
    @Mensaje VARCHAR(500) output
)
AS
BEGIN
    -- Inicializamos los valores de salida
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verificamos si ya existe un producto con el mismo nombre y detalle, excluyendo el producto actual
    IF EXISTS (SELECT * FROM PRODUCTOS WHERE nombre_producto = @nombre_producto AND detalle_producto = @detalle_producto AND id_producto != @id_producto)
    BEGIN
        -- Si existe otro producto con el mismo nombre y detalle, enviamos un mensaje de error
        SET @Mensaje = 'Ya existe un producto con el mismo nombre y detalle.';
    END
    ELSE
    BEGIN
        -- Si no existe, actualizamos el producto
        UPDATE PRODUCTOS
        SET
            detalle_producto = @detalle_producto,
            nombre_producto = @nombre_producto,
            precio_compra = @precio_compra,
            precio_venta = @precio_venta,
            stock = @stock,
            stock_minimo = @stock_minimo,
            id_marca = @id_marca,
            id_categoria = @id_categoria,
            id_proveedor = @id_proveedor,
            imagen = @imagen
        WHERE
            id_producto = @id_producto;

        -- Indicamos que la operación fue exitosa
        SET @Respuesta = 1;
        SET @Mensaje = 'Producto actualizado correctamente';
    END
END;


CREATE PROC SP_PRODUCTO_ELIMINAR(
    @id_producto INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si la categoria existe
    IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE id_producto = @id_producto)
    BEGIN
        DECLARE @fecha_baja_actual DATE;
        SELECT @fecha_baja_actual = fecha_baja FROM PRODUCTOS WHERE id_producto = @id_producto;

        -- Si la fecha de baja es NULL, la actualiza con la fecha actual
        IF @fecha_baja_actual IS NULL
        BEGIN
            UPDATE PRODUCTOS
            SET fecha_baja = CAST(GETDATE() AS DATE)
            WHERE id_producto = @id_producto;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si la fecha de baja no es NULL, la pone a NULL
            UPDATE PRODUCTOS
            SET fecha_baja = NULL
            WHERE id_producto = @id_producto;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el producto no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'El producto no existe.';
    END
END
  --------------------------------------------------------------
 go

 /*ACTUALIZAR PRODUCTO*/ 
CREATE PROCEDURE SP_PRODUCTO_ACTUALIZAR (
    @id_producto INT,
    @cantidad INT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;
    SET @Mensaje = '';

    IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE id_producto = @id_producto)
    BEGIN
        IF @cantidad > 0
        BEGIN
            IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE id_producto = @id_producto AND stock >= @cantidad)
            BEGIN
                UPDATE PRODUCTOS
                SET stock = stock - @cantidad
                WHERE id_producto = @id_producto;
                SET @Resultado = 1;
            END
            ELSE
            BEGIN
                SET @Mensaje = 'Stock insuficiente para realizar la operación.';
            END
        END
        ELSE
        BEGIN
            SET @Mensaje = 'La cantidad debe ser mayor a 0.';
        END
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El producto no existe!';
    END
END
GO
select * from PERSONAS
select * from ventas 
select  * from DETALLE_VENTAS
select * from PRODUCTOS
update productos
set stock = 0
where id_producto = 3
  --------------------------------------------------------------
 go

/*REGISTRAR PROVEEDOR*/
CREATE PROCEDURE SP_PROVEEDOR_REGISTRAR(
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

/*EDITAR PROVEEDOR*/
CREATE PROC SP_PROVEEDOR_EDITAR(
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

/*ELIMINAR PROVEEDOR*/
CREATE PROC SP_PROVEEDOR_ELIMINAR(
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

  --------------------------------------------------------------
 go

 select * from MARCAS
 /*REGISTRAR MARCAS*/
CREATE PROC SP_MARCAS_REGISTRAR(
    @nombre VARCHAR(20),
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''
    
    IF NOT EXISTS (SELECT * FROM marcas WHERE nombre = @nombre)
    BEGIN
        INSERT INTO MARCAS(nombre, fecha_alta) 
        VALUES(@nombre, GETDATE());

        SET @Resultado = SCOPE_IDENTITY();
        SET @Mensaje = 'Marca registrada exitosamente.';
    END
    ELSE
    BEGIN
        SET @Mensaje = 'La marca ' + @nombre + ' ya existe!';
    END
END
GO
select * from MARCAS
/*EDITAR MARCAS*/
CREATE PROC SP_MARCAS_EDITAR(
	@id_marca INT,
    @nombre VARCHAR(20),
	@Resultado bit output,
	@Mensaje VARCHAR(500) output 
 )
 as
 begin
	set @Resultado = 0
	IF NOT EXISTS (SELECT * FROM MARCAS WHERE nombre = @nombre and id_marca != @id_marca)
		begin
			update MARCAS set
			nombre = @nombre
			WHERE id_marca = @id_marca
			set @Resultado = 1
			set @Mensaje = 'Edición existosa!'
		end
	else
		begin
			set @Resultado = 0
			set @Mensaje = 'La marca ' + @nombre + ' ya existe!'
		end
end
go

CREATE PROC SP_MARCAS_ELIMINAR(
    @id_marca INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    -- Verifica si la categoria existe
    IF EXISTS (SELECT 1 FROM MARCAS WHERE id_marca = @id_marca)
    BEGIN
        DECLARE @fecha_baja_actual DATE;
        SELECT @fecha_baja_actual = fecha_baja FROM MARCAS WHERE @id_marca = id_marca;

        -- Si la fecha de baja es NULL, la actualiza con la fecha actual
        IF @fecha_baja_actual IS NULL
        BEGIN
            UPDATE MARCAS
            SET fecha_baja = CAST(GETDATE() AS DATE)
            WHERE id_marca = @id_marca;

            SET @Respuesta = 0;
        END
        ELSE
        BEGIN
            -- Si la fecha de baja no es NULL, la pone a NULL
            UPDATE MARCAS
            SET fecha_baja = NULL
            WHERE id_marca = @id_marca;

            SET @Respuesta = 1;
        END
    END
    ELSE
    BEGIN
        -- Si el usuario no existe, devuelve un mensaje de error
        SET @Respuesta = 0;
        SET @Mensaje = 'La Marca no existe.';
    END
END
go
select * from USUARIOS





-------------------------------------------------------------
GO

/*REGISTRAR VENTA*/
CREATE PROCEDURE SP_VENTAS_REGISTRAR(
    @importe_total DECIMAL(18,2),
    @id_usuario INT,
    @id_cliente INT,
	@IdVentaResultado int output,
	@Mensaje VARCHAR(500) output 
 )
 as
 BEGIN
	set @IdVentaResultado = 0
	set @Mensaje = ''
	IF EXISTS (SELECT * FROM USUARIOS WHERE id_usuario = @id_usuario)
		BEGIN
			IF EXISTS (SELECT * FROM PERSONAS WHERE id_persona = @id_cliente)
				BEGIN
					INSERT INTO VENTAS(importe_total,fecha_factura,id_usuario,id_cliente) VALUES(@importe_total, GETDATE(),@id_usuario,@id_cliente)

					set @IdVentaResultado = SCOPE_IDENTITY()
					SET @Mensaje = 'Venta registrada';
				END
			ELSE
				BEGIN
					set @Mensaje = 'El cliente no existe!'
				END
		END
	ELSE
		BEGIN
			set @Mensaje = 'El vendedor no existe!'
		END
END
GO



 -------------------------------------------------------------
GO

/*REGISTRAR DETALLE_VENTAS*/
CREATE PROCEDURE SP_DETALLE_VENTAS_REGISTRAR(
    @cantidad INT,
	@subtotal DECIMAL(18,2),
	@id_producto INT,
	@id_venta INT,
    @IdDetalleVentaResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdDetalleVentaResultado = 0
    SET @Mensaje = ''
    
    IF EXISTS (SELECT 1 FROM VENTAS WHERE id_venta = @id_venta)
		BEGIN
			INSERT INTO DETALLE_VENTAS(cantidad, subtotal, id_producto, id_venta) 
			VALUES(@cantidad,@subtotal,@id_producto,@id_venta);

			SET @IdDetalleVentaResultado = SCOPE_IDENTITY();
		END
    ELSE
		BEGIN
			SET @Mensaje = 'No existe FACTURA para esta venta!';
		END
END
GO

CREATE PROCEDURE Reporte_Usuario
    @usuario INT,
    @mensaje NVARCHAR(100) OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ventas v WHERE v.id_usuario = @usuario)
    BEGIN
        SELECT v.fecha_factura, 
               dv.cantidad, 
               p.nombre_producto, 
               p.precio_venta, 
               dv.subtotal
        FROM ventas v
        INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
        INNER JOIN productos p ON dv.id_producto = p.id_producto
        WHERE v.id_usuario = @usuario;

        SET @mensaje = 'Consulta exitosa, se encontraron ventas para el usuario.';
    END
    ELSE
    BEGIN
        SET @mensaje = 'El usuario no tiene ventas o no existe.';
    END
END;
EXEC Reporte_Usuario @usuario = 4, @mensaje = @mensaje OUTPUT;


 -------------------------------------------------------------
GO


select * from PERSONAS p
join DOMICILIOS d on d.id_persona = p.id_persona
select * from PRODUCTOS



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
 select p.dni from PERSONAS p
 join DOMICILIOS d on d.id_persona=p.id_persona
 select * from PRODUCTOS
 /*REGISTRAR MARCAS*/
 declare @idmarcagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_REGISTRARMARCAS 'TOPPER', @idmarcagenerada output, @mensajegenerado output
 
 select @idmarcagenerada
 select @mensajegenerado
 GO

 /*EDITAR MARCAS*/
 declare @idmarcagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARMARCAS 2,'TOPPER', @idmarcagenerada output, @mensajegenerado output
 
 select @idmarcagenerada
 select @mensajegenerado
 GO

  /*EDITAR CATEGORIAS*/
 declare @idmarcagenerada int
 declare @mensajegenerado varchar(500)

 exec SP_EDITARCATEGORIAS 2,'CAMISETAS', @idmarcagenerada output, @mensajegenerado output
 
 select @idmarcagenerada
 select @mensajegenerado
 GO
  select * from USUARIOS

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
 select * from PROVEEDORES
 select * from CATEGORIAS
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

 select * from PRODUCTOS

 select * from MARCAS
>>>>>>> 7d6a0c2a18c081626269c263c191ea1c11f3cffd
=======
=======
>>>>>>> 53d25f6e474e6eafaed02dd8074556453c398f5e
 select * from MARCAS
=======
>>>>>>> rama-matias

select * from VENTAS v
join DETALLE_VENTAS dv on dv.id_venta = v.id_venta
where v.id_venta = 17

<<<<<<< HEAD
 SELECT * FROM PERSONAS p
 JOIN DOMICILIOS d ON d.id_persona = p.id_persona

 SELECT * FROM PRODUCTOS

 SELECT * FROM VENTAS;
 SELECT * FROM DETALLE_VENTAS;
 
 delete from VENTAS where id_venta > 0
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
=======

>>>>>>> d3bcf23359550fb9b6c27b2c04c9375ab115bffe

 select * from PRODUCTOS

 select * from MARCAS




RESTORE DATABASE [RunFit]
FROM DISK = 'C:\Users\JULIO_GAMER_PC\Desktop\runfit_3_repositorio\BackUp\15-10-2024_12 horas _32 minutos _14 segundos.bak'
WITH REPLACE;

select * from usuarios
select * from ventas
select * from DETALLE_VENTAS
select * from PRODUCTOS
select nombre_producto,detalle_producto,stock,stock_minimo,m.nombre,c.nombre_categoria,p.razon_social from productos pr
inner join MARCAS m on m.id_marca=pr.id_marca
inner join CATEGORIAS c on c.id_categoria=pr.id_categoria
inner join PROVEEDORES p on p.id_proveedor=pr.id_proveedor
where stock=stock_minimo+5 or stock<=stock_minimo

where v.fecha_factura between

--- script de mejor vendedor en numeros
select  u.nombre_usuario as vendedor,sum(v.importe_total ) as total_ventas
from usuarios u
inner join ventas v on (v.id_usuario=u.id_usuario)
group by u.nombre_usuario

<<<<<<< HEAD
=======
>>>>>>> 7d6a0c2a18c081626269c263c191ea1c11f3cffd
>>>>>>> rama-julio
>>>>>>> 53d25f6e474e6eafaed02dd8074556453c398f5e
>>>>>>> rama-matias
=======
--scrip mejor vendedor en cantidades
SELECT 
    u.nombre_usuario AS vendedor, 
    p.nombre_producto,
    SUM(dv.cantidad) AS cantidad_total
FROM 
    usuarios u
INNER JOIN 
    ventas v ON v.id_usuario = u.id_usuario
INNER JOIN 
    detalle_ventas dv ON dv.id_venta = v.id_venta
INNER JOIN 
    productos p ON p.id_producto = dv.id_producto
GROUP BY 
    u.nombre_usuario, p.nombre_producto
	order by cantidad_total desc


SELECT 
    p.nombre_producto,
    SUM(dv.cantidad) AS cantidad_total
FROM 
    productos p
INNER JOIN 
    detalle_ventas dv ON p.id_producto = dv.id_producto
GROUP BY 
    p.nombre_producto;


	WITH VentasMaximas AS (
    SELECT 
        u.nombre_usuario AS vendedor,
        p.nombre_producto,
        SUM(dv.cantidad) AS cantidad_total,
        ROW_NUMBER() OVER (PARTITION BY p.nombre_producto ORDER BY SUM(dv.cantidad) DESC) AS fila
    FROM 
        usuarios u
    INNER JOIN 
        ventas v ON v.id_usuario = u.id_usuario
    INNER JOIN 
        detalle_ventas dv ON dv.id_venta = v.id_venta
    INNER JOIN 
        productos p ON p.id_producto = dv.id_producto
    GROUP BY 
        u.nombre_usuario, p.nombre_producto
)
SELECT 
    vendedor, 
    nombre_producto, 
    cantidad_total
FROM 
    VentasMaximas
WHERE 
    fila = 1;

SELECT 
    u.nombre_usuario AS vendedor, 
	v.fecha_factura,
    SUM(dv.cantidad) AS cantidad_total,
    SUM(dv.subtotal) AS importe_total
FROM 
    usuarios u
INNER JOIN 
    ventas v ON v.id_usuario = u.id_usuario
INNER JOIN 
    detalle_ventas dv ON dv.id_venta = v.id_venta
GROUP BY 
    u.nombre_usuario
ORDER BY 
    importe_total DESC;

 SELECT 
     p.nombre_producto,
     SUM(dv.cantidad) AS cantidad_total
 FROM 
     productos p
 INNER JOIN 
     detalle_ventas dv ON p.id_producto = dv.id_producto
 INNER JOIN 
     ventas v ON dv.id_venta = v.id_venta
 
 GROUP BY 
     p.nombre_producto

	  SELECT 
     p.nombre_producto,
     SUM(dv.subtotal) AS monto_total
 FROM 
     productos p
 INNER JOIN 
     detalle_ventas dv ON p.id_producto = dv.id_producto
 INNER JOIN 
     ventas v ON dv.id_venta = v.id_venta

 GROUP BY 
     p.nombre_producto
	 order by monto_total desc


	SELECT 
    p.nombre_producto,
     SUM(dv.subtotal) AS monto_total
FROM 
    productos p
INNER JOIN 
    detalle_ventas dv ON p.id_producto = dv.id_producto
INNER JOIN 
    ventas v ON dv.id_venta = v.id_venta

GROUP BY 
    p.nombre_producto
<<<<<<< HEAD
ORDER BY 
    cantidad_total DESC;
>>>>>>> d3bcf23359550fb9b6c27b2c04c9375ab115bffe
=======
    order by monto_total desc
	select * from PRODUCTOS
	select * from DETALLE_VENTAS 
	update DETALLE_VENTAS
	set subtotal=1000 where id_producto=14


	SELECT p.nombre_producto, 
       SUM(dv.cantidad) AS total_cantidad, 
       MAX(p.precio_venta) AS precio_venta, 
       SUM(dv.subtotal) AS total_subtotal,
       MAX(v.fecha_factura) AS ultima_fecha_factura
FROM ventas v
INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
INNER JOIN productos p ON dv.id_producto = p.id_producto

GROUP BY p.nombre_producto
        order by total_subtotal desc
>>>>>>> 5c4bacb58284dc80cdae2419a7e3632fc0949535
=======
SELECT v.id_venta, v.importe_total, v.fecha_factura,
u.nombre_usuario,
p.apellido, p.nombre, p.dni, p.telefono, p.email,
d.calle, d.altura, d.manzana, d.casa, d.piso, d.departamento,
dv.cantidad, prod.nombre_producto, prod.detalle_producto, prod.precio_venta, dv.subtotal
FROM VENTAS v
JOIN DETALLE_VENTAS dv ON dv.id_venta = v.id_venta
JOIN PERSONAS p ON p.id_persona = v.id_cliente
JOIN USUARIOS u ON u.id_usuario = v.id_usuario
JOIN PRODUCTOS prod ON prod.id_producto = dv.id_producto
JOIN DOMICILIOS d ON d.id_persona = v.id_cliente
where v.id_venta = 17
>>>>>>> rama-matias
select * from usuarios
