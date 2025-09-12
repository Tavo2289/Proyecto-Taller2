use bd_sistemaVentasElectronica
/*agrego columna tipo_documento a la compra*/

select * from Compra

alter table Compra add  tipo_documento varchar(50)
alter table Compra add  nro_documento varchar(50)
/*agrego columna precioCompra y venta a la detallecompra*/
select * from DetalleCompra

alter table DetalleCompra add precioCompra decimal(10,2) default 1
alter table DetalleCompra add precioVenta decimal(10,2) default 1

/*agrego columna montoTotal  y elimino precio_unitario y subtotal a la tabla detallecompra*/
alter table DetalleCompra add montoTotal decimal(10,2) default 1
alter table DetalleCompra drop column precio_unitario
alter table DetalleCompra drop column subtotal





/*PROCESOS PARA REGISTRAR UNA COMPRA */

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
    [IdProducto] int NULL,
    [PrecioCompra] decimal(18,2) NULL,
    [PrecioVenta] decimal(18,2) NULL,
    [Cantidad] int NULL,
    [MontoTotal] decimal(18,2) NULL
)

go

-- Este procedimiento almacenado registra una nueva compra y sus detalles
-- en la base de datos, asegurando la integridad de los datos mediante una transacción.
-- También actualiza el stock de los productos comprados.

CREATE PROCEDURE sp_RegistrarCompra(
    @IdUsuario int,
    @IdProveedor int,
    @TipoDocumento varchar(500),
    @NumeroDocumento varchar(500),
    @MontoTotal decimal(18,2),
    @DetalleCompra [EDetalle_Compra] READONLY,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
    -- Inicia un bloque TRY para manejar posibles errores.
    begin try
        -- Declara una variable para almacenar el ID de la compra recién insertada.
        declare @idcompra int = 0
        -- Inicializa la variable de resultado en 1 (éxito).
        set @Resultado = 1
        -- Inicializa la variable de mensaje en una cadena vacía.
        set @Mensaje = ''

        -- Inicia una transacción para asegurar que todas las operaciones se realicen o ninguna.
        begin transaction registro

        -- Inserta un nuevo registro en la tabla 'COMPRA' con los datos proporcionados.
        insert into COMPRA(id_usuario, id_proveedor, tipo_documento, nro_documento, total)
        values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

        -- Asigna a la variable @idcompra el ID de la última fila insertada en la tabla COMPRA.
        set @idcompra = SCOPE_IDENTITY()
        
        -- Inserta los detalles de la compra en la tabla 'DetalleCompra'
        -- Selecciona los datos de la tabla de entrada @DetalleCompra.
        insert into DetalleCompra(id_compra, id_producto, precioCompra, precioVenta, Cantidad, montoTotal)
        select @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

        -- Actualiza el stock, precio de compra y precio de venta de los productos.
        update p set p.stock = p.stock + dc.Cantidad,
            p.precio_compra = dc.PrecioCompra,
            p.precio_venta = dc.PrecioVenta
        -- Une la tabla 'PRODUCTO' (con el alias p) con la tabla de detalles de la compra (@DetalleCompra, con el alias dc).
        from PRODUCTO p
        inner join @DetalleCompra dc on dc.IdProducto = p.id_producto

        -- Si todas las operaciones fueron exitosas, confirma la transacción.
        commit transaction registro
    end try
    begin catch
        -- En caso de error, este bloque se ejecuta.
        -- Establece el resultado en 0 para indicar un fallo.
        set @Resultado = 0
        -- Almacena el mensaje de error en la variable de mensaje.
        set @Mensaje = ERROR_MESSAGE()
        -- Deshace todas las operaciones realizadas en la transacción.
        rollback transaction registro
    end catch
end


