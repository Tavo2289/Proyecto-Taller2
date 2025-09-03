select * from Usuario;
use bd_sistemaVentasElectronica;


ALTER TABLE Usuario
ADD CONSTRAINT DF_Usuario_estado DEFAULT 1 FOR estado; /*restriccion para  que el valor del estado por defecto sea 1*/
EXEC sp_rename 'Permisos.nombre_permiso', 'nombre_menu', 'COLUMN';

insert into Rol (nombre_rol,fecha_baja) values ('administrador',null);  /*se agrega un rol administrador, id=1 */
insert into Rol (nombre_rol,fecha_baja) values ('vendedor',null);  /*se agrega un rol administrador, id=2 */


insert into Usuario(nombre,apellido, nro_documento, contraseña,fecha_baja,estado,id_rol) 
values ('antonio','romero', '44212381','admin123',null ,1,1); /*se agrega usuario en la tabla usuario */

insert into Usuario(nombre,apellido, nro_documento, contraseña,fecha_baja,estado,id_rol) 
values ('iara','perez esquivel', '44212382','vendedor123',null ,1,2); /*se agrega usuario en la tabla usuario */


select * from Permisos;
EXEC sp_rename 'Permisos.nombre_permiso', 'nombre_menu', 'COLUMN';

insert into Permisos (id_rol, nombre_menu) values /*se agrega los nombres de los menus a los que tiene permiso*/
(1,'iconUsuario'),
(1,'iconMantenedor'),
(1,'iconVentas'),
(1,'iconCompras'),
(1,'iconClientes'),
(1,'iconProveedores'),
(1,'iconReportes'),
(1,'iconAcercaDe');


insert into Permisos (id_rol, nombre_menu) values /*se agrega los nombres de los menus a los que tiene permiso id-rol=2*/
(2,'iconVentas'),
(2,'iconCompras'),
(2,'iconClientes'),
(2,'iconProveedores'),
(2,'iconAcercaDe');

delete from Permisos


select p.id_rol ,p.nombre_menu from Permisos p  /* */
inner join Rol r on r.id_rol = p.id_rol
inner join Usuario u on u.id_rol = r.id_rol
where u.id_usuario = 1;

select * from Rol

select * from Usuario

alter table Usuario add  gmail varchar (100)
go
ALTER TABLE Usuario
ALTER COLUMN gmail VARCHAR(100);


UPDATE Usuario
SET gmail = 'antonioramonromero246@gmail.com'
WHERE id_usuario = 1;


UPDATE Usuario
SET gmail = 'iaraperezesquivel@gmail.com'
WHERE id_usuario = 2;


select u.id_usuario, u.nombre, u.apellido, u.nro_documento, u.contraseña, u.fecha_alta ,u.estado, u.gmail, r.id_rol, r.nombre_rol from usuario u
inner join rol r on r.id_rol = u.id_rol


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
	INNER JOIN USUARIO U ON U.id_usuario = V.id_usuario
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

select * from Permisos
select * from Rol
select * from Usuario



go



alter table Categoria add constraint df_estado DEFAULT 1 FOR estado; /*agregamos contrain que por defecto sea 1*/


/*---------------PROCEDIMIENTOS PARA CATEGORIA-----------------------*/
--PROCEDIMIENTO PARA GUARDAR CATEGORIA
alter PROC SP_RegistrarCategoria(
	@estado bit,
    @Descripcion varchar(50),
    @Resultado int output,
	@mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
    IF NOT EXISTS (SELECT * FROM Categoria WHERE nombre_categoria = @Descripcion) /*si no existe otra categoria igual*/
    begin
        insert into Categoria(nombre_categoria,estado) values (@Descripcion,@estado) /*agrega categoria a la tabla categoria*/
        set @Resultado = SCOPE_IDENTITY() /*resultado == id_categoria*/
    end
		else
			set @mensaje = 'No se puede repetir la descripcion de una categoria'
end

select * from Categoria


--PROCEDIMIENTO PARA EDITAR  CATEGORIA
alter PROC SP_EditarCategoria(
	@estado bit,
	@id_categoria int,
    @Descripcion varchar(50),
    @Resultado bit output,
	@mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    IF NOT EXISTS (SELECT * FROM Categoria WHERE nombre_categoria = @Descripcion and id_categoria != @id_categoria) /*si no existe otra categoria igual y que sea distinta el id*/
    
        update Categoria set
		nombre_categoria = @Descripcion,
		estado = @estado
		where id_categoria = @id_categoria
   
		else
		begin
			set @Resultado=0
			set @mensaje = 'No se puede repetir la descripcion de una categoria'

		end
end

go

--PROCEDIMIENTO PARA ELIMINAR  CATEGORIA
create PROC SP_EliminarCategoria(
	@id_categoria int,
    @Resultado bit output,
	@mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
    IF NOT EXISTS (
	select * from Categoria c
	inner join Producto p on p.id_categoria = c.id_categoria
	where c.id_categoria = @id_categoria  /*si la categoria no esta relacionada a un producto*/
	)
	begin
		delete top (1) from Categoria where id_categoria = @id_categoria /* eliminamos*/
	end
   
		else
		begin
			set @Resultado=0
			set @mensaje = 'La categoria se encuentra relacionada a un producto '

		end
end



---------------------------------------------------------------------------
select * from Producto

select id_producto, codigo,nombre_producto, c.id_categoria,c.descripcion[descripcionCategoria],stock,precioCompra, precioVenta, p.estado from Producto p
inner join Categoria c on r.idRol = p.id_categoria

/*------------------------------------*/

/* PROCEDIMIENTO PARA PRODUCTO */

/*REGISTRAR PRODUCTO*/
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


select * from Categoria


insert into Categoria (nombre_categoria, estado) values ('comestible', 1) 
