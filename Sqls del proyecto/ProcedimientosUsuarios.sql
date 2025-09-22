use bd_sistemaVentasElectronica

select * from usuario
/**REGISTRAR USUARIO**/
alter PROC SP_REGISTRAR_USUARIO(
	@documento varchar(50),
	@nombre varchar(50),
	@apellido varchar(50),
	@gmail varchar(50),
	@contraseña varchar(50),
	@id_rol int,
	@estado bit,
	@idUsuarioResultado int output,
	@mensaje varchar(500) output

)
as
begin
	set @idUsuarioResultado =0
	set @mensaje=''

	if not exists(select * from Usuario where nro_documento =  @documento)
	begin

		insert into Usuario(nro_documento,nombre,apellido,gmail,contraseña,id_rol,estado) values
		(@documento,@nombre, @apellido,@gmail,@contraseña,@id_rol,@estado)

		set @idUsuarioResultado = SCOPE_IDENTITY()

	end
	else
		set  @mensaje = 'No se puede repetir el documento para mas de un Usuario'

end

go

/**CONSULTA***/
declare  @idUsuarioGenerado int
declare @mensaje varchar(500)

exec  SP_REGISTRAR_USUARIO '12346' ,'pruebas','originales', 'testing@gmail.com','456',2,1,@idUsuarioGenerado output,@mensaje output

select  @idUsuarioGenerado

select @mensaje

select * from Usuario

GO

/*EDITAR USUARIO*/
alter PROC SP_EDITAR_USUARIO(
    @id_usuario int,
	@documento varchar(50),
	@nombre varchar(50),
	@apellido varchar(50),
	@gmail varchar(50),
	@contraseña varchar(50),
	@id_rol int,
	@estado bit,
	@respuesta bit output,
	@mensaje varchar(500) output

)
as
begin
	set @respuesta =0
	set @mensaje=''

	if not exists(select * from Usuario where nro_documento =  @documento and id_usuario !=  @id_usuario)
	begin

		update Usuario set
		nro_documento = @documento,
		nombre = @nombre,
		apellido = @apellido,
		gmail= @gmail,
		contraseña = @contraseña,
		id_rol= @id_rol,
		estado= @estado
		where id_usuario = @id_usuario


		set @respuesta = 1;

	end
	else
		set  @mensaje = 'No se puede repetir el documento para mas de un Usuario'

end

go


/*PRUEBA DE EDITAR USUARIO*/
declare  @respuesta int
declare @mensaje varchar(500)

exec  SP_EDITAR_USUARIO 1,'44212381' ,'antonio','romero', 'antonioramonromero246@gmail.com','123',1,1,@respuesta output,@mensaje output

select  @respuesta
select @mensaje

select *from Usuario


/*PROCEDIMIENTO ELIMINAR USUARIO */

GO


alter PROC SP_ELIMINAR_USUARIO(
    @id_usuario int,
	@respuesta int output,
	@mensaje varchar(500) output

)
as
begin
	set @respuesta =0 /*si se elimina un usuario cambia a 1*/
	set @mensaje=''
	declare @pasoReglas bit =1

	IF EXISTS ( SELECT * FROM COMPRA C 
	INNER JOIN USUARIO U ON U.id_usuario = C.id_usuario
	WHERE U.id_usuario = @id_usuario
	)/*SI EL USUARIO ESTA RELACIONADO A UNA COMPRA*/
		BEGIN
			set @pasoReglas =0 /*no paso las condiciones para eliminar usuario*/
			set @respuesta =0
			set @mensaje= @mensaje +'No se puede Eliminar  usuarios que se encuentren relacionados a una Compra\n'

		END


	IF EXISTS ( SELECT * FROM VENTA V 
	INNER JOIN USUARIO U ON U.id_usuario = V.IdUsuario
	WHERE U.id_usuario = @id_usuario
	)/*SI EL USUARIO ESTA RELACIONADO A UNA VENTA*/
		BEGIN
			set @pasoReglas =0 /*no paso las condiciones para eliminar usuario*/
			set @respuesta =0
			set @mensaje= @mensaje + 'No se puede Eliminar  usuarios que se encuentren relacionados a una Venta\n'

		END


		if(@pasoReglas = 1) /*si no esta relacionado a un compra o venta*/
		begin
			delete from Usuario where id_usuario= @id_usuario
			set @respuesta =1
		end

end