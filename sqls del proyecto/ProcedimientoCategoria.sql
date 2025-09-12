use bd_sistemaVentasElectronica



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