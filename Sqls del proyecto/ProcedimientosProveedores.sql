use bd_sistemaVentasElectronica


go

select * from Proveedor
alter table Proveedor drop column direccion

go

create procedure SP_RegistrarProveedor(
@documento varchar (50),
@razon_social varchar (50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)as
begin
	set @resultado =0
	declare @id_persona int
	if not exists (select * from Proveedor where nro_documento = @documento)
	begin
		insert into	Proveedor (nro_documento,razon_social,correo,telefono,estado) values
		(@documento,@razon_social,@correo,@telefono,@estado)
		
		set @resultado = SCOPE_IDENTITY()

	end
	else

		set @mensaje = 'El proveedor ya esta cargado en la base de datos'
end

go




alter PROC SP_EditarProveedor(
    @id_proveedor int,
	@documento varchar(50),
	@razon_social varchar(50),
	@correo varchar(50),
	@telefono varchar (50),
	@estado bit,
	@respuesta bit output,
	@mensaje varchar(500) output

)
as
begin
	set @respuesta =1

	if not exists(select * from Proveedor where nro_documento =  @documento and id_proveedor !=  @id_proveedor)
	begin

		update Proveedor set
		nro_documento = @documento,
		razon_social = @razon_social,
		correo= @correo,
		telefono = @telefono,
		estado= @estado
		where id_proveedor = @id_proveedor
	


		

	end
	else
		begin
			set @respuesta =0
			set  @mensaje = 'No se puede repetir el documento para mas de un Proveedor'
		end

end

go



create PROC SP_EliminarProveedor(
    @id_proveedor int,
	@respuesta int output,
	@mensaje varchar(500) output

)
as
begin
	set @respuesta = 1

	IF NOT EXISTS (select * from Proveedor p
	inner join Compra c on p.id_proveedor = c.id_proveedor
	where p.id_proveedor = @id_proveedor
	)/*SI EL proveedor ESTA RELACIONADO A UNA COMPRA*/
		BEGIN
			delete top (1) from Proveedor where id_proveedor = @id_proveedor

		END
		else
			begin
				set @respuesta = 0
				set @mensaje = 'El proveedor se encuentra relacionado a una compra'
			end





end

/*select*/


select id_proveedor,nro_documento, razon_social , telefono,correo, estado from Proveedor

alter table Proveedor add constraint DF_estadoProveedor default 1 for estado

insert into Proveedor (nro_documento, razon_social , telefono,correo) values ('44212332','VERDULERO S.R.L' ,'3794727930','verdulero@mail.com')


