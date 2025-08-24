create database bd_sistemaVentasElectronica;

use bd_sistemaVentasElectronica;


go



CREATE TABLE Categoria (
    id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    nombre_categoria VARCHAR(100) NOT NULL,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate(),
    estado BIT NOT NULL
);

go



CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    nro_documento VARCHAR(20) UNIQUE NOT NULL,
    direccion VARCHAR(200),
    telefono VARCHAR(20),
    correo VARCHAR(100) UNIQUE,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate(),
    estado BIT NOT NULL
);

go


CREATE TABLE Rol (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre_rol VARCHAR(50) NOT NULL,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate()
);

go


CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    nro_documento VARCHAR(20) UNIQUE NOT NULL,
    contraseña VARCHAR(255) NOT NULL,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate(),
    estado BIT NOT NULL,
    id_rol INT NOT NULL FOREIGN KEY REFERENCES Rol(id_rol)
);

go 


CREATE TABLE Proveedor (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    razon_social VARCHAR(150) NOT NULL,
    nro_documento VARCHAR(20) UNIQUE NOT NULL,
    direccion VARCHAR(200),
    telefono VARCHAR(20),
    correo VARCHAR(100),
    fecha_alta DATETIME default getdate() not null,
    fecha_baja DATETIME default getdate(),
    estado BIT NOT NULL
);

go



CREATE TABLE MetodoPago (
    id_metodo_pago INT IDENTITY(1,1) PRIMARY KEY,
    nombre_metodo VARCHAR(50) NOT NULL,
    descripcion VARCHAR(200),
    estado BIT NOT NULL,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate()
);


CREATE TABLE Producto (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    nombre_producto VARCHAR(100) NOT NULL,
    descripcion VARCHAR(200),
    precio DECIMAL(10,2) NOT NULL,
    stock INT NOT NULL,
    stock_minimo INT NOT NULL,
    fecha_alta DATETIME default getdate(),
    fecha_baja DATETIME default getdate(),
    estado BIT NOT NULL,
    id_categoria INT NOT NULL FOREIGN KEY REFERENCES Categoria(id_categoria),
    id_proveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedor(id_proveedor)
);


CREATE TABLE Compra (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL FOREIGN KEY REFERENCES Usuario(id_usuario),
    id_proveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedor(id_proveedor),
    fecha_compra DATETIME default getdate(),
    total DECIMAL(12,2) NOT NULL, 
    estado BIT NOT NULL
);

go


CREATE TABLE DetalleCompra (
    id_detalle_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_compra INT NOT NULL FOREIGN KEY REFERENCES Compra(id_compra),
    id_producto INT NOT NULL FOREIGN KEY REFERENCES Producto(id_producto),
    id_metodo_pago INT NOT NULL FOREIGN KEY REFERENCES MetodoPago(id_metodo_pago),
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(12,2) NOT NULL,
    estado BIT NOT NULL
);

go 

CREATE TABLE Venta (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT NOT NULL FOREIGN KEY REFERENCES Cliente(id_cliente),
    id_usuario INT NOT NULL FOREIGN KEY REFERENCES Usuario(id_usuario),
    importe_total DECIMAL(12,2) NOT NULL,
    fecha_venta DATETIME default getdate() NOT NULL
);

go


CREATE TABLE DetalleVenta (
    id_detalle_venta INT IDENTITY(1,1) PRIMARY KEY,
    id_venta INT NOT NULL FOREIGN KEY REFERENCES Venta(id_venta),
    id_producto INT NOT NULL FOREIGN KEY REFERENCES Producto(id_producto),
    id_metodo_pago INT NOT NULL FOREIGN KEY REFERENCES MetodoPago(id_metodo_pago),
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(12,2) NOT NULL,
    pago_recibido DECIMAL(12,2) NOT NULL,
    cambio DECIMAL(12,2) NOT NULL
);

go


CREATE TABLE Permisos (
    id_permiso INT IDENTITY(1,1) PRIMARY KEY,
    id_rol INT NOT NULL FOREIGN KEY REFERENCES Rol(id_rol),
    nombre_permiso VARCHAR(100) NOT NULL,
    fecha_creacion DATETIME default getdate() NOT NULL
);
