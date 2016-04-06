
/* Modificamos la tabla para que el campo sea único */
/*ALTER TABLE PRODUCTOS add constraint campo_unico UNIQUE (cod_prod)*/

/*
	PROCEDIMIENTOS ALMACENADOS
*/

/* PROCEDIMIENTO MOSTRAR PRODUCTO */

CREATE PROCEDURE MostrarProducto
@cod_prod varchar(4)
AS
BEGIN
	SELECT NOMBRE, EXISTENCIA
	FROM productos
	WHERE cod_prod = @cod_prod
END
GO
/* PROCEDIMIENTO REGISTRAR PRODUCTO */

CREATE PROCEDURE RegistrarProductos
@cod_prod as varchar(4),
@nombre as varchar(50),
@existencia as int
AS
BEGIN
	INSERT INTO productos (cod_prod,nombre,existencia) values (@cod_prod,@nombre,@existencia)
END
GO
/* PROCEDIMIENTO MODIFICAR PRODUCTO */

CREATE PROCEDURE ModificarProducto
@cod_prod as varchar(4),
@nombre as varchar(50),
@existencia as int
AS
BEGIN
	UPDATE productos SET nombre = @nombre, existencia = @existencia
	WHERE cod_prod = @cod_prod
END
GO

/* PROCEDIMIENTO ELIMINAR PRODUCTO */

CREATE PROCEDURE EliminarProducto
@cod_prod as varchar(4)
AS
BEGIN
	DELETE
	FROM productos
	WHERE cod_prod = @cod_prod
END
GO

/* PROCEDIMIENTO SUMAR EXISTENCIA */

CREATE PROCEDURE SumarExistencia
@cod_prod as varchar(4),
@existencia as int
AS
BEGIN
	UPDATE productos SET existencia = existencia + @existencia WHERE cod_prod = @cod_prod
END
