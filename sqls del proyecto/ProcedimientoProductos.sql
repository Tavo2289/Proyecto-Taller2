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


/*ELIMINAR PRODUCTO*/

create PROC SP_EliminarProducto(
@id_producto int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DetalleCompra dc
	INNER JOIN Producto p ON p.id_producto = dc.id_producto
	WHERE p.id_producto = @id_producto
	)
	BEGIN
	set @pasoreglas = 0
	set @respuesta = 0
	set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionados a una COMPRA\n'
	END

	if(@pasoreglas = 1)
	begin
		delete from Producto where id_producto = @id_producto
		set @respuesta = 1
	end
end
