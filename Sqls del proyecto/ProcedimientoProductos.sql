use bd_sistemaVentasElectronica

*REGISTRAR PRODUCTO*/
create PROC sp_RegistrarProducto(
@codigo varchar(20),
@nombre_producto varchar(30),
@descripcion varchar(30),
@id_categoria int,
@estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE codigo = @Codigo)
	begin
		insert into producto(codigo,nombre_producto,descripcion,id_categoria,estado) values (@codigo,@nombre_producto,@descripcion,@id_categoria,@estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'
end
go


/*MODIFICAR PRODUCTO*/
create procedure  sp_ModificarProducto(
@id_producto int,
@codigo varchar(20),
@nombre_producto varchar(30),
@descripcion varchar(30),
@id_categoria int,
@estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM producto WHERE codigo = @Codigo and id_producto != @id_producto)

			update Producto set
			codigo = @codigo,
			nombre_producto = @nombre_producto,
			descripcion = @descripcion,
			id_categoria = @id_categoria,
			estado = @estado
			where id_producto = @id_producto
		ELSE
		begin
			SET @Resultado = 0
			SET @Mensaje = 'Ya existe un producto con el mismo codigo'
		end
end
 
go



/*PROCEDIMIENTO PARA ELIMINAR PRODUCTO*/

ALTER PROC SP_EliminarProducto(
    @id_producto int,
    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN
    SET @respuesta = 0
    SET @mensaje = ''
    DECLARE @pasoreglas bit = 1

    -- Validacion 1: Verificar si el producto esta relacionado a una COMPRA
    IF EXISTS (SELECT * FROM DetalleCompra dc
    INNER JOIN Producto p ON p.id_producto = dc.id_producto
    WHERE p.id_producto = @id_producto
    )
    BEGIN
        SET @pasoreglas = 0
        SET @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA.'
    END

    -- Validacion 2: Verificar si el producto esta relacionado a una VENTA
    IF EXISTS (SELECT * FROM DetalleVenta dv
    INNER JOIN Producto p ON p.id_producto = dv.id_producto
    WHERE p.id_producto = @id_producto
    )
    BEGIN
        SET @pasoreglas = 0
        SET @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA.'
    END

    -- Si el producto no esta relacionado ni a una compra ni a una venta
    IF (@pasoreglas = 1)
    BEGIN
        DELETE FROM Producto WHERE id_producto = @id_producto
        SET @respuesta = 1
    END
END