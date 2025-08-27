create database BD_sistemaGestionVentas;


 use BD_sistemaGestionVentas;
go 



create table DOMICILIO(
	id_domicilio int unique identity not null,
	calle varchar (150) not null,
	altura int not null,
	casa varchar (60) ,
	departamento varchar (50),
	piso int ,
	constraint pk_idDomicilio primary key ( id_domicilio ) 
)


go



create table ROL(

	id_rol int unique identity,
	nombre_rol varchar (50),
	fecha_alta datetime default getdate(), /*si no se coloca fecha , default fecha altual*/
	fecha_baja datetime default getdate(),
	constraint pk_idRol primary key (id_rol)


)


go


create table PERSONA (
	id_persona int unique identity,
	dni int not null,
	nombre varchar (50) not null,
	apellido varchar (50) not null,
	email varchar (50) not null,
	telefono varchar (50) not null,
	fecha_nacimiento datetime not null,
	sexo char ,
	constraint pk_idPersona primary key(id_persona)



)

go

create table MARCA (

	id_marca int identity  unique not null,
	nombre varchar (50),
	fecha_alta datetime default getdate(),
	fecha_baja datetime default getdate(),
	CONSTRAINT pk_idMarca PRIMARY KEY (id_marca)
)

GO


CREATE TABLE CATEGORIA(
	id_categoria int IDENTITY unique  NOT NULL,
	nombre_categoria VARCHAR (50),
	fecha_alta DATETIME DEFAULT GETDATE(),
	fecha_baja DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_idCategoria PRIMARY KEY (id_categoria)



)


GO


CREATE TABLE PROVEEDOR (

	id_proveedor int IDENTITY unique NOT NULL,
	razon_social VARCHAR(90),
	cuit int NOT NULL,
	descripcion VARCHAR (160),
	fecha_alta DATETIME DEFAULT GETDATE(),
	fecha_baja DATETIME DEFAULT GETDATE(),
	id_persona int,
	CONSTRAINT pk_idProveedor PRIMARY KEY (id_proveedor),
	CONSTRAINT fk_idProveedor FOREIGN KEY (id_persona) REFERENCES PERSONA(id_persona)



)

GO


CREATE TABLE CLIENTE (
	id_cliente int IDENTITY  unique NOT NULL,
	cuit int not null,
	fecha_alta DATETIME default getdate(),
	fecha_baja datetime default getdate(),
	id_persona int,
	constraint pk_idCLiente primary key (id_cliente),
	constraint fk_idPersona_cliente FOREIGN key (id_persona) REFERENCES PERSONA(id_persona)




)


go



CREATE TABLE USUARIO(
	id_usuario int identity unique not null,
	nombre_usuario varchar (50) not null,
	contraseña varchar (50) not null,
	fecha_alta datetime default getdate(),
	fecha_baja datetime default getdate(),
	id_persona int,
	constraint pk_idUsuario primary key (id_usuario),
	constraint fk_idPersona_usuario FOREIGN key (id_persona) REFERENCES PERSONA(id_persona)




)

go

CREATE TABLE VENTA(
     id_venta int identity  unique not null,
	 importe_total decimal not null,
	 fecha_factura datetime default getdate(),
	 id_usuario int,
	 id_cliente int,
	 constraint pk_idVenta primary key (id_venta),
	 constraint fk_idUsuario FOREIGN key (id_usuario) REFERENCES USUARIO(id_usuario),
	 constraint fk_idCliente FOREIGN key (id_cliente) REFERENCES CLIENTE (id_cliente)



)


go



create table METODO_PAGO(
	id_metodoPago int identity unique not null,
	nombre varchar(50) not null,
	descripcion varchar(150),
	activo bit ,
	constraint pk_idMetodoPago primary key (id_metodoPago)



)


GO

create table PRODUCTO(

		id_producto int identity unique not null,
		nombre_pruducto varchar(50) not null,
		precio_compra decimal not null,
		stock int not null,
		imagen varbinary(MAX),
		detalle_pruducto varchar (200),
		fecha_alta datetime default getdate(),
		fecha_baja datetime default getdate(),
		stock_minimo int not null,
		id_marca int,
		id_categoria int,
		id_proveedor int,
		estado bit,
		constraint pk_idProducto primary key (id_pruducto),
		constraint fk_idMarca_producto FOREIGN key (id_marca) REFERENCES MARCA(id_marca),
		constraint fk_idCategoria_producto FOREIGN key (id_categoria) REFERENCES CATEGORIA(id_categoria),
		constraint fk_idProveedor_producto FOREIGN key (id_proveedor) REFERENCES PROVEEDOR(id_proveedor)

)


GO

create table DETALLE_VENTA(
	id_detalleVenta int identity unique not null,
	cantidad int not null,
	subtotal decimal not null,
	id_producto int not null,
	id_venta int not null,
	id_metodoPago int not null,
	constraint pk_idDetalleVenta primary key (id_detalleVenta),
	constraint fk_idProducto_detalleVenta FOREIGN key (id_producto) REFERENCES PRODUCTO (id_producto),
	constraint fk_idVenta FOREIGN key (id_venta) REFERENCES VENTA(id_venta),
	constraint fk_idMetodoPago FOREIGN key (id_metodoPago) REFERENCES METODO_PAGO(id_metodoPago)
)


go

