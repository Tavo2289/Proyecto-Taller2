use  bd_sistemaVentasElectronica

SELECT * FROM Cliente



/**REGISTRAR Cliente**/
create PROC SP_REGISTRAR_CLIENTE(

	@nombre varchar(50),
	@apellido varchar(50),
	@documento varchar(50),
	@gmail varchar(50),
	@telefono varchar(50),
	@estado bit,
	@Resultado int output,
	@mensaje varchar(500) output

)
as
begin
	set @Resultado =0
	set @mensaje=''

	if not exists(select * from Cliente where nro_documento =  @documento)
	begin

		insert into Cliente(nro_documento,nombre,apellido,correo,telefono,estado) values
		(@documento,@nombre, @apellido,@gmail,@telefono,@estado)

		set @Resultado = SCOPE_IDENTITY()

	end
	else
		set  @mensaje = 'No se puede repetir el documento para mas de un Cliente'

end

go

/**CONSULTA***/
go

/*EDITAR Cliente*/
CREATE PROC SP_EDITAR_CLIENTE(
    @id_Cliente int,
	@documento varchar(50),
	@nombre varchar(50),
	@apellido varchar(50),
	@gmail varchar(50),
	@telefono varchar (50),
	@estado bit,
	@respuesta bit output,
	@mensaje varchar(500) output

)
as
begin
	set @respuesta =0
	set @mensaje=''

	if not exists(select * from Cliente where nro_documento =  @documento and id_cliente !=  @id_Cliente)
	begin

		update Cliente set
		nro_documento = @documento,
		nombre = @nombre,
		apellido = @apellido,
		correo= @gmail,
		telefono = @telefono,
		estado= @estado
		where id_cliente = @id_Cliente


		set @respuesta = 1;

	end
	else
		set @respuesta =0
		set  @mensaje = 'No se puede repetir el documento para mas de un Cliente'

end

go

select * from Cliente
insert into Cliente (nombre,apellido,nro_documento, telefono,correo,estado) values ('pepe','pollo','2131213','3794232123','pepe@gmail.com',1)
insert into Cliente (nombre,apellido,nro_documento, telefono,correo,estado) values ('pepardo','pollo2','2131214','3794232122','2pepe@gmail.com',1)
insert into Cliente (nombre,apellido,nro_documento, telefono,correo,estado) values ('pepito','pollo3','2131216','3794232121','1pepe@gmail.com',1)





/*SELECT PARA CLIENTE*/

select id_cliente,nombre,apellido,nro_documento,telefono,correo, estado from Cliente 

select * from Compra