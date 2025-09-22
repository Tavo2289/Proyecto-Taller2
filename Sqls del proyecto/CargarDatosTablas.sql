
--iconUsuario
--iconMantenedor
--iconVentas
--iconCompras
--iconClientes
--iconProveedores
--iconReportes
--iconAcercaDe
--iconVentas
--iconCompras
--iconClientes
--iconProveedores
--iconAcercaDe


/*insersciones de datos*/


--TABLA ROL
INSERT INTO Rol (nombre_rol) VALUES
('Administrador'),
('Vendedor'),
('Super Administrador');
GO

--TABLA PERMISOS
INSERT INTO Permisos(id_rol, nombre_menu) VALUES (2, 'iconVentas');
INSERT INTO Permisos (id_rol, nombre_menu) VALUES (2, 'iconClientes');
INSERT INTO Permisos (id_rol, nombre_menu) VALUES (2, 'iconReportes');
INSERT INTO Permisos (id_rol, nombre_menu) VALUES (2, 'iconAcercaDe');


-- Permisos para las vistas de administración
INSERT INTO Permisos (id_rol, nombre_menu) VALUES
(1, 'iconMantenedor'),
(1, 'iconCompras'),
(1, 'iconProveedores'),
(1, 'iconReportes'),
(1, 'iconAcercaDe');


-- Permisos para todas las vistas
INSERT INTO Permisos (id_rol, nombre_menu) VALUES
(3, 'iconUsuario'),
(3, 'iconMantenedor'),
(3, 'iconVentas'),
(3, 'iconCompras'),
(3, 'iconClientes'),
(3, 'iconProveedores'),
(3, 'iconReportes'),
(3, 'iconAcercaDe');





-- Usuarios: uno por cada rol
INSERT INTO Usuario (nombre, apellido, nro_documento, contraseña,gmail, estado, id_rol) VALUES
('Juan', 'Perez', '21321344', 'admin123','juanperez@gmail.com', 1, 1),
('Maria', 'Gomez', '2345678901', 'vendedor123','mariagomez@gmail.com', 1, 2),
('Antonio', 'Romero', '44212381', 'superadmin123','antonioromero@gmail.com', 1, 3);
GO


-- Categorías para PC
INSERT INTO Categoria (nombre_categoria, estado) VALUES
('Placas Madre', 1),
('Procesadores', 1),
('Tarjetas Gráficas', 1),
('Memorias RAM', 1),
('Discos SSD', 1),
('Fuentes de Poder', 1),
('Gabinetes', 1),
('Monitores', 1),
('Teclados', 1),
('Mouses', 1);
GO


INSERT INTO Proveedor (razon_social, nro_documento, telefono, correo, estado) VALUES
('Intel Partners', '20123456789',  '1122334455', 'contacto@intel.com', 1),
('AMD Distribuidores', '20987654321',  '1133445566', 'info@amd.com', 1),
('Nvidia Gaming SRL', '20567890123',  '1144556677', 'ventas@nvidia.com', 1),
('Kingston Memory', '20345678901',  '1155667788', 'contacto@kingston.com', 1),
('Western Digital', '20234567890',  '1166778899', 'gerencia@wd.com', 1),
('Corsair Tech S.A.C.', '20112233445', '1177889900', 'corsair@tech.com', 1),
('NZXT Cases', '20998877665','1188990011', 'info@nzxt.com', 1),
('LG Displays', '20443322110',  '1199001122', 'contacto@lg.com', 1),
('Logitech Peripherals', '20556677889',  '1100112233', 'contacto@logitech.com', 1),
('Razer Inc.', '20667788990',  '1111223344', 'ventas@razer.com', 1);
GO



-- Clientes
INSERT INTO Cliente (nombre, apellido, nro_documento, direccion, telefono, correo, estado) VALUES
('Ana', 'Diaz', '4012345678', 'Calle 10 #20', '3514567890', 'ana.d@mail.com', 1),
('Luis', 'Gomez', '4123456789', 'Av. San Martin 300', '3515678901', 'luis.g@mail.com', 1),
('Sofia', 'Fernandez', '4234567890', 'Belgrano 500', '3516789012', 'sofia.f@mail.com', 1),
('Pedro', 'Rodriguez', '4345678901', 'Rivadavia 75', '3517890123', 'pedro.r@mail.com', 1),
('Laura', 'Martínez', '4456789012', 'Juncal 120', '3518901234', 'laura.m@mail.com', 1),
('Diego', 'García', '4567890123', 'Corrientes 450', '3519012345', 'diego.g@mail.com', 1),
('Valeria', 'Perez', '4678901234', 'Maipú 25', '3511234567', 'valeria.p@mail.com', 1),
('Javier', 'Sánchez', '4789012345', 'San Lorenzo 100', '3512345678', 'javier.s@mail.com', 1),
('Camila', 'Torres', '4890123456', 'Las Heras 30', '3513456789', 'camila.t@mail.com', 1),
('Alejandro', 'Ruiz', '4901234567', 'Independencia 200', '3514567890', 'alejandro.r@mail.com', 1);
GO


INSERT INTO Producto (nombre_producto, descripcion, stock, precioVenta, precioCompra, codigo, estado, id_categoria) VALUES
('Placa Madre MSI Z690', 'Soporte para procesadores Intel', 50, 25000.00, 20000.00, 'MB-MSI-Z690', 1, 1 ),
('Procesador AMD Ryzen 7', 'Procesador de 8 núcleos, 16 hilos', 75, 30000.00, 25000.00, 'CPU-AMD-R7', 1, 2),
('Tarjeta Gráfica RTX 4070', '12GB GDDR6X', 30, 80000.00, 70000.00, 'GPU-RTX-4070', 1, 3),
('Memoria RAM Corsair 16GB', 'DDR4 3200MHz', 150, 8000.00, 6500.00, 'RAM-COR-16', 1, 4),
('SSD Kingston 1TB', 'NVMe PCIe Gen4', 200, 10000.00, 8500.00, 'SSD-KIN-1T', 1, 5),
('Fuente de Poder Corsair 750W', '80+ Gold', 80, 12000.00, 10500.00, 'PSU-COR-750', 1, 6),
('Gabinete NZXT H5', 'Gabinete ATX de vidrio templado', 40, 15000.00, 12500.00, 'CASE-NZXT-H5', 1, 7),
('Monitor LG 27"', 'Monitor 4K IPS, 144Hz', 30, 45000.00, 40000.00, 'MON-LG-27', 1, 8),
('Teclado Logitech G Pro', 'Teclado mecánico TKL', 120, 9000.00, 7500.00, 'KEY-LOGI-GPRO', 1, 9),
('Mouse Razer Deathadder', 'Mouse ergonómico para gaming', 180, 6000.00, 5000.00, 'MOU-RAZ-DEATH', 1, 10);
GO

-- Compras
INSERT INTO Compra (id_usuario, id_proveedor, total, estado, tipo_documento, nro_documento) VALUES
(1, 1, 20000.00, 1, 'Factura', 'A-001-001'),
(1, 2, 25000.00, 1, 'Factura', 'A-001-002'),
(1, 3, 70000.00, 1, 'Factura', 'A-001-003'),
(1, 4, 6500.00, 1, 'Factura', 'A-001-004'),
(1, 5, 8500.00, 1, 'Factura', 'A-001-005'),
(1, 6, 10500.00, 1, 'Factura', 'A-001-006'),
(1, 7, 12500.00, 1, 'Factura', 'A-001-007'),
(1, 8, 40000.00, 1, 'Factura', 'A-001-008'),
(1, 9, 7500.00, 1, 'Factura', 'A-001-009'),
(1, 10, 5000.00, 1, 'Factura', 'A-001-010');
GO

-- Detalles de Compra
INSERT INTO DetalleCompra (id_compra, id_producto, cantidad, precio_compra, precio_venta, subtotal) VALUES
(1, 1, 1, 20000.00, 25000.00, 20000.00),
(2, 2, 1, 25000.00, 30000.00, 25000.00),
(3, 3, 1, 70000.00, 80000.00, 70000.00),
(4, 4, 1, 6500.00, 8000.00, 6500.00),
(5, 5, 1, 8500.00, 10000.00, 8500.00),
(6, 6, 1, 10500.00, 12000.00, 10500.00),
(7, 7, 1, 12500.00, 15000.00, 12500.00),
(8, 8, 1, 40000.00, 45000.00, 40000.00),
(9, 9, 1, 7500.00, 9000.00, 7500.00),
(10, 10, 1, 5000.00, 6000.00, 5000.00);
GO



INSERT INTO Venta (id_usuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal, id_cliente) VALUES
(2, 'Boleta', '00001', '4012345678', 'Ana Diaz', 25000.00, 0.00, 25000.00, 1),
(2, 'Boleta', '00002', '4123456789', 'Luis Gomez', 30000.00, 0.00, 30000.00, 2),
(2, 'Factura', 'A-001-000003', '4234567890', 'Sofia Fernandez', 80000.00, 0.00, 80000.00, 3),
(2, 'Boleta', '00004', '4345678901', 'Pedro Rodriguez', 8000.00, 0.00, 8000.00, 4),
(2, 'Factura', 'A-001-000005', '4456789012', 'Laura Martínez', 10000.00, 0.00, 10000.00, 5),
(2, 'Boleta', '00006', '4567890123', 'Diego García', 12000.00, 0.00, 12000.00, 6),
(2, 'Boleta', '00007', '4678901234', 'Valeria Perez', 15000.00, 0.00, 15000.00, 7),
(2, 'Factura', 'A-001-000008', '4789012345', 'Javier Sánchez', 45000.00, 0.00, 45000.00, 8),
(2, 'Boleta', '00009', '4890123456', 'Camila Torres', 9000.00, 0.00, 9000.00, 9),
(2, 'Factura', 'A-001-000010', '4901234567', 'Alejandro Ruiz', 6000.00, 0.00, 6000.00, 10);
GO


-- Detalles de Venta
INSERT INTO DetalleVenta (id_venta, id_producto, cantidad, precioVenta, subtotal) VALUES
(1, 1, 1, 25000.00, 25000.00),
(2, 2, 1, 30000.00, 30000.00),
(3, 3, 1, 80000.00, 80000.00),
(4, 4, 1, 8000.00, 8000.00),
(5, 5, 1, 10000.00, 10000.00),
(6, 6, 1, 12000.00, 12000.00),
(7, 7, 1, 15000.00, 15000.00),
(8, 8, 1, 45000.00, 45000.00),
(9, 9, 1, 9000.00, 9000.00),
(10, 10, 1, 6000.00, 6000.00);
GO


INSERT INTO Negocio (nombre, ruc, direccion) VALUES
('PC Central', '20123456789', 'Av. De la Tecnología #50');
GO