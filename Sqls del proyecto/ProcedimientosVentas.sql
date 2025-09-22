use bd_sistemaVentasElectronica


select * from DETALLE_VENTA
select * from VENTA


/*cracion tabla venta*/

CREATE TABLE VENTA (
    IdVenta INT  IDENTITY(1,1),
    IdUsuario INT,
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    DocumentoCliente VARCHAR(50),
    NombreCliente VARCHAR(100),
    MontoPago DECIMAL(10, 2),
    MontoCambio DECIMAL(10, 2),
    MontoTotal DECIMAL(10, 2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    constraint pk_idVenta primary key(IdVenta),
    constraint fk_idUsuario foreign key (IdUsuario) references usuario(id_usuario)
);



CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
    [IdProducto] int NULL,
    [PrecioVenta] decimal(18,2) NULL,
    [Cantidad] int NULL,
    [SubTotal] decimal(18,2) NULL
)

GO

alter procedure usp_RegistrarVenta(
    @IdUsuario int,
    @TipoDocumento varchar(500),
    @NumeroDocumento varchar(500),
    @DocumentoCliente varchar(500),
    @NombreCliente varchar(500),
    @MontoPago decimal(18,2),
    @MontoCambio decimal(18,2),
    @MontoTotal decimal(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
    begin try
        declare @idventa int = 0
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction registro

        insert into VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
        values(@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

        set @idventa = SCOPE_IDENTITY()

        insert into DETALLE_VENTA(id_venta, id_producto, precio_venta, cantidad, subtotal)
        select @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

        commit transaction registro

    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction registro
    end catch
end


GO

 /*consulta detalle venta*/
select v.IdVenta,u.nombre, u.apellido,
v.DocumentoCliente,v.NombreCliente,
v.TipoDocumento,v.NumeroDocumento,
v.MontoPago,v.MontoCambio,v.MontoTotal,
convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.id_usuario = v.IdUsuario
where v.NumeroDocumento = '00001'

go
select 
    p.nombre_producto, 
    dv.precio_venta, 
    dv.cantidad, 
    dv.SubTotal
from DETALLE_VENTA dv
inner join PRODUCTO p on p.id_producto = dv.id_producto
where dv.id_venta = 1