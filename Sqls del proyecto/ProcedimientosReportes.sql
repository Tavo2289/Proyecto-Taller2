use bd_sistemaVentasElectronica
select * from DetalleCompra


go
select
CONVERT(char(10), c.fecha_compra,103)[FechaRegistro],c.tipo_documento, c.nro_documento,c.total,
u.nombre,u.apellido,
pr.nro_documento[DocumentoProveedor],pr.razon_social,
p.Codigo[CodigoProducto],p.nombre_producto[NombreProducto],ca.nombre_categoria[Categoria],dc.precioCompra,dc.precioVenta,dc.cantidad,dc.montoTotal[SubTotal]
from COMPRA c
inner join USUARIO u on u.id_usuario = c.id_usuario
inner join Proveedor pr on pr.id_proveedor = c.id_proveedor
inner join DetalleCompra dc on dc.id_compra = c.id_compra
inner join PRODUCTO p on p.id_producto = dc.id_producto
inner join CATEGORIA ca on ca.id_categoria = p.id_categoria
where CONVERT(date, c.fecha_compra) between '18/10/2021' and '20/10/2025'
and pr.id_proveedor = 1

/*Procedimiento compras*/
alter PROC sp_ReporteCompras(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
as
begin

SET DATEFORMAT dmy;

select
CONVERT(char(10), c.fecha_compra,103)[FechaRegistro],c.tipo_documento, c.nro_documento as documentoCompra,c.total,
u.nombre,u.apellido,
pr.nro_documento[DocumentoProveedor],pr.razon_social,
p.Codigo[CodigoProducto],p.nombre_producto[NombreProducto],ca.nombre_categoria[Categoria],dc.precioCompra,dc.precioVenta,dc.cantidad,dc.montoTotal[SubTotal]
from COMPRA c
inner join USUARIO u on u.id_usuario = c.id_usuario
inner join Proveedor pr on pr.id_proveedor = c.id_proveedor
inner join DetalleCompra dc on dc.id_compra = c.id_compra
inner join PRODUCTO p on p.id_producto = dc.id_producto
inner join CATEGORIA ca on ca.id_categoria = p.id_categoria
where CONVERT(date, c.fecha_compra) between @fechainicio and @fechafin
and pr.id_proveedor = iif(@idproveedor=0, pr.id_proveedor,@idproveedor)
end


/*Procedimientos ventas*/
go
select * from Venta
select * from DETALLE_VENTA

alter PROC sp_ReporteVentas(
@fechainicio varchar(10),
@fechafin varchar(10)
)
as
begin

SET DATEFORMAT dmy;
select
id_venta,
convert(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
u.nombre, u.apellido,
v.DocumentoCliente,v.NombreCliente,
p.Codigo[CodigoProducto],p.nombre_producto[NombreProducto],ca.nombre_categoria[Categoria],dv.precio_venta,dv.cantidad,dv.subTotal
from Venta v
inner join USUARIO u on u.id_usuario = v.IdUsuario
inner join DETALLE_VENTA dv on dv.id_venta = v.IdVenta
inner join PRODUCTO p on p.id_producto = dv.id_producto
inner join CATEGORIA ca on ca.id_categoria = p.id_categoria
where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end

select * from Usuario