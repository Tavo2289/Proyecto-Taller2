use bd_sistemaVentasElectronica


 create table DETALLE_VENTA(
 id_detalleVenta int  identity,
 id_venta int ,
 id_producto int,
 precio_venta decimal(10,2),
 cantidad int,
 subtotal decimal(10,2),
 fecha_registro datetime default getdate(),
 constraint pk_idDetalleVenta primary key (id_detalleVenta),
 constraint  fk_idVenta foreign key  (id_venta) references Venta(id_venta),
 constraint  fk_idProducto foreign key  (id_producto) references Producto(id_producto)




 )
 go

create table NEGOCIO(
id_negocio int ,
nombre varchar(60),
ruc varchar(60),
direccion varchar(60),
logo varbinary(max) NULL,
constraint pk_idNegocio primary key (id_negocio)
)

/*INSERT*/

insert into NEGOCIO (id_negocio,nombre,ruc,direccion) values (1,'Electronica S.R.L','101010','AV 3 DE ABRIL 1800')

SELECT id_negocio,nombre,ruc,direccion FROM NEGOCIO

select * from NEGOCIO

