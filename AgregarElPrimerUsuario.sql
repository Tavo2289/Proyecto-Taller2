select * from Usuario;
select * from Rol;

ALTER TABLE Usuario
ADD CONSTRAINT DF_Usuario_estado DEFAULT 1 FOR estado; /*restriccion para  que el valor del estado por defecto sea 1*/

insert into Rol (nombre_rol,fecha_baja) values ('administrador',null);  /*se agrega un rol administrador, id=1 */


insert into Usuario(nombre,apellido, nro_documento, contraseña,fecha_baja,estado,id_rol) 
values ('antonio','romero', '44212381','admin123',null ,1,1); /*se agrega usuario en la tabla usuario */