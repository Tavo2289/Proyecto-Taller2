-- Eliminar la base de datos si ya existe para recrearla


CREATE DATABASE bd_sistemaVentasElectronica;
GO

USE bd_sistemaVentasElectronica;
GO

-- Tabla Rol
CREATE TABLE Rol (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre_rol VARCHAR(50),
    fecha_alta DATETIME DEFAULT GETDATE()
);
GO

-- Tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    nro_documento VARCHAR(20) UNIQUE,
    contrasena VARCHAR(255),
    gmail VARCHAR(100),
    fecha_alta DATETIME DEFAULT GETDATE(),
    estado BIT,
    id_rol INT FOREIGN KEY REFERENCES Rol(id_rol)
);
GO

-- Tabla Categoria
CREATE TABLE Categoria (
    id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    nombre_categoria VARCHAR(100),
    fecha_alta DATETIME DEFAULT GETDATE(),
    estado BIT
);
GO

-- Tabla Cliente
CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    nro_documento VARCHAR(20) UNIQUE,
    direccion VARCHAR(200),
    telefono VARCHAR(20),
    correo VARCHAR(100) UNIQUE,
    fecha_alta DATETIME DEFAULT GETDATE(),
    estado BIT
);
GO

-- Tabla Proveedor
CREATE TABLE Proveedor (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    razon_social VARCHAR(150),
    nro_documento VARCHAR(20) UNIQUE,
    telefono VARCHAR(20),
    correo VARCHAR(100),
    fecha_alta DATETIME DEFAULT GETDATE(),
    estado BIT
);
GO

-- Tabla Producto
CREATE TABLE Producto (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    nombre_producto VARCHAR(100),
    descripcion VARCHAR(200),
    stock INT,
    precio DECIMAL(10,2),
    precioCompra DECIMAL(10,2),
    codigo VARCHAR(50),
    fecha_alta DATETIME DEFAULT GETDATE(),
    estado BIT,
    id_categoria INT FOREIGN KEY REFERENCES Categoria(id_categoria),
    id_proveedor INT FOREIGN KEY REFERENCES Proveedor(id_proveedor)
);
GO

-- Tabla Compra
CREATE TABLE Compra (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    id_proveedor INT FOREIGN KEY REFERENCES Proveedor(id_proveedor),
    fecha_compra DATETIME DEFAULT GETDATE(),
    total DECIMAL(12,2),
    estado BIT,
    tipo_documento VARCHAR(50),
    nro_documento VARCHAR(50)
);
GO

-- Tabla DetalleCompra
CREATE TABLE DetalleCompra (
    id_detalle_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_compra INT FOREIGN KEY REFERENCES Compra(id_compra),
    id_producto INT FOREIGN KEY REFERENCES Producto(id_producto),
    cantidad INT,
    precio_compra DECIMAL(10,2),
    precio_venta DECIMAL(10,2),
    subtotal DECIMAL(12,2)
);
GO

-- Tabla Venta
CREATE TABLE Venta (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    DocumentoCliente VARCHAR(20),
    NombreCliente VARCHAR(100),
    MontoPago DECIMAL(12,2),
    MontoCambio DECIMAL(12,2),
    MontoTotal DECIMAL(12,2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    id_cliente INT FOREIGN KEY REFERENCES Cliente(id_cliente)
);
GO

-- Tabla DetalleVenta
CREATE TABLE DetalleVenta (
    id_detalle_venta INT IDENTITY(1,1) PRIMARY KEY,
    id_venta INT FOREIGN KEY REFERENCES Venta(id_venta),
    id_producto INT FOREIGN KEY REFERENCES Producto(id_producto),
    precioVenta DECIMAL(10,2),
    cantidad INT,
    subtotal DECIMAL(12,2),
    fecha_registro DATETIME DEFAULT GETDATE()
);
GO

-- Tabla Permisos
CREATE TABLE Permisos (
    id_permiso INT IDENTITY(1,1) PRIMARY KEY,
    id_rol INT FOREIGN KEY REFERENCES Rol(id_rol),
    nombre_menu VARCHAR(100),
    fecha_creacion DATETIME DEFAULT GETDATE()
);
GO

-- Tabla Negocio
CREATE TABLE Negocio (
    id_negocio int ,
    nombre varchar(60),
    ruc varchar(60),
    direccion varchar(60),
    logo varbinary(max) NULL,
    constraint pk_idNegocio primary key (id_negocio)
);
GO