--Procedimiento Almacenado Adminstrador
--Insetar Administrador
--Select * From Administrador


Use master
GO
Use MCTuristic
GO
--++++++++++++++++++++Procedimiento Almacenado Adminstrador++++++++++++++++++++++++++
-- Este procedimiento sirve para agregar un nuevo administrador en la base de datos
CREATE PROC insertar_administrador
(
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento varchar(25)
)
as
INSERT INTO Administrador (Nombre,Apellidos,Email,Contrasena,TelefonoCelular,FechaNacimiento) 
VALUES (@Nombre,@Apellidos,@Email,@Contrasena,@TelefonoCelular,@FechaNacimiento)
Go
--Actualizar Administrador
-- Este procedimiento sirve para actualizar los datos de un administrador previamente registrado
CREATE PROC actualizar_administrador
(
	@IdAdminstrador int,
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento varchar(25)
)
as
UPDATE Administrador 
SET Nombre = @Nombre,Apellidos= @Apellidos,Email = @Email,Contrasena = @Contrasena,TelefonoCelular = @TelefonoCelular,FechaNacimiento= @FechaNacimiento 
WHERE IdAdministrador = @IdAdminstrador
Go
--Eliminar Administrador
-- Este procedimiento sirve para eliminar en su totalidad a un administrador que se encuentre en la base de datos
Create proc eliminar_administrador
(
	@IdAdministrador int
)
as
DELETE FROM Administrador WHERE IdAdministrador = @IdAdministrador
GO

-- Este procedimiento sirve para visualizar los datos de un administrador junto con la dirección que le pertenece
Create procedure ver_administrador
as
SELECT     dbo.Administrador.IdAdministrador,  dbo.Administrador.Nombre, dbo.Administrador.Apellidos, dbo.Administrador.Email, dbo.Administrador.TelefonoCelular, dbo.Administrador.FechaNacimiento, dbo.Direccion.idDireccion ,dbo.Direccion.Calle, dbo.Direccion.Cruzamiento, 
                         dbo.Direccion.Numero, dbo.Direccion.Colonia, dbo.Direccion.Descripcion, dbo.Direccion.Estado, dbo.Direccion.CodPostal
FROM            dbo.Administrador INNER JOIN
                         dbo.Direccion ON dbo.Administrador.IdAdministrador = dbo.Direccion.IdAdministrador
GO

--------------------------------Procedimiento Almacenado usuario-----------------------------------
--Select * from Usuario



---Seleccionar el usuario actual insertado
-- Este procedimiento sirve para seleccionar el último registro ingresado en la tabla de usuario
create procedure usuario_reciente
as
select MAX([IdUsuario]) as Maximo from Usuario
go

--Insetar Usuario
-- Este procedimiento sirve para agregar un nuevo usuario en la base de datos
CREATE PROC insertar_usuario
(
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento varchar(25),
	@Foto image
)
as
INSERT INTO Usuario(Nombre,Apellidos,Email,Contrasena,TelefonoCelular,FechaNacimiento,Foto) 
VALUES (@Nombre,@Apellidos,@Email,@Contrasena,@TelefonoCelular,@FechaNacimiento,@Foto)
Go
--Actualizar usuario
-- Este procedimiento sirve para actualizar los datos de un usuario previamente registrado
CREATE PROC actualizar_usuario
(
	@IdUsuario int,
	@Nombre varchar(50),
	@Apellidos varchar(50),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(50),
	@FechaNacimiento varchar(25),
	@Foto image
)
as
UPDATE Usuario 
SET Nombre = @Nombre,Apellidos= @Apellidos,Email = @Email,Contrasena = @Contrasena,TelefonoCelular = @TelefonoCelular,FechaNacimiento= @FechaNacimiento, Foto = @Foto
WHERE IdUsuario = @IdUsuario
Go
--Eliminar usuario
-- Este procedimiento sirve para eliminar en su totalidad a un usuario que se encuentre en la base de datos
Create proc eliminar_usuario
(
	@IdUsuario int
)
as
DELETE FROM Usuario WHERE IdUsuario = @IdUsuario
GO

-- Este procedimiento sirve para visualizar los datos de un administrador junto con la dirección que le pertenece
create procedure ver_usuario
as
SELECT        dbo.Usuario.IdUsuario, dbo.Usuario.Nombre, dbo.Usuario.Apellidos, dbo.Usuario.Email, dbo.Usuario.TelefonoCelular, dbo.Usuario.FechaNacimiento, dbo.Direccion.Calle, dbo.Direccion.idDireccion, 
                         dbo.Direccion.Cruzamiento, dbo.Direccion.Numero, dbo.Direccion.Descripcion, dbo.Direccion.Estado, dbo.Direccion.CodPostal
FROM            dbo.Direccion INNER JOIN
                         dbo.Usuario ON dbo.Direccion.IdUsuario = dbo.Usuario.IdUsuario
GO
---------------------------------Procedimiento Almacenado Dirección----------------------------------------
-----***Dirección Usuario-----------
-- Este procedimiento sirve para agregar una nueva dirección en la base de datos
Create procedure insertar_direccion_usuario
(
	@Calle varchar(50),
	@Cruzamiento varchar(50),
	@Numero varchar(50),
	@Descripcion varchar(50),
	@Colonia varchar(50),
	@Estado varchar(50),
	@CodPostal varchar(50),
	@IdUsuario int
)
as
INSERT INTO Direccion (Calle,Cruzamiento,Numero,Descripcion,Colonia,Estado,CodPostal,IdUsuario,IdAdministrador)
VALUES (@Calle,@Cruzamiento,@Numero,@Descripcion,@Colonia,@Estado,@CodPostal,@IdUsuario,null)
go
-- Actualizar direccion
-- Este procedimiento sirve para actualizar los datos de una dirección previamente registrada
Create procedure actualizar_direccion_usuario
(
	@idDireccion int,
	@Calle varchar(50),
	@Cruzamiento varchar(50),
	@Numero varchar(50),
	@Descripcion varchar(50),
	@Colonia varchar(50),
	@Estado varchar(50),
	@CodPostal varchar(50),
	@IdUsuario int
	
)
as
UPDATE Direccion SET  Calle = @Calle,Cruzamiento = @Cruzamiento,Numero = @Numero,Descripcion = @Descripcion,Colonia = @Colonia,Estado = @Estado,CodPostal = @CodPostal,IdUsuario = @IdUsuario,IdAdministrador = null
where idDireccion = @idDireccion
go



--Insetar Administrador
-- Este procedimiento sirve para agregar una nueva dirección de un administrador en la base de datos
Create procedure insertar_direccion
(
	@Calle varchar(50),
	@Cruzamiento varchar(50),
	@Numero varchar(50),
	@Descripcion varchar(50),
	@Colonia varchar(50),
	@Estado varchar(50),
	@CodPostal varchar(50),
	@IdUsuario int,
	@IdAdministrador int
)
as
INSERT INTO Direccion (Calle,Cruzamiento,Numero,Descripcion,Colonia,Estado,CodPostal,IdUsuario,IdAdministrador)
VALUES (@Calle,@Cruzamiento,@Numero,@Descripcion,@Colonia,@Estado,@CodPostal,@IdUsuario,@IdAdministrador)
go
-- Actualizar direccion
-- Este procedimiento sirve para actualizar los datos de una dirección de un administrador previamente registrada
Create procedure actualizar_direccion
(
	@idDireccion int,
	@Calle varchar(50),
	@Cruzamiento varchar(50),
	@Numero varchar(50),
	@Descripcion varchar(50),
	@Colonia varchar(50),
	@Estado varchar(50),
	@CodPostal varchar(50),
	@IdUsuario int,
	@IdAdministrador int
)
as
UPDATE Direccion SET  Calle = @Calle,Cruzamiento = @Cruzamiento,Numero = @Numero,Descripcion = @Descripcion,Colonia = @Colonia,Estado = @Estado,CodPostal = @CodPostal,IdUsuario = @IdUsuario,IdAdministrador = @IdAdministrador
where idDireccion = @idDireccion
go

-- Este procedimiento sirve para eliminar en su totalidad una dirección que se encuentre en la base de datos
create procedure eliminar_direccion
(
	@idDireccion int
)
as
Delete from Direccion where idDireccion = @idDireccion
go

--------------------------------Procedimiento Almacenado establecimiento-----------------------------------
----Insertar Establecimiento
-- Este procedimiento sirve para agregar un nuevo establecimiento en la base de datos
Create procedure insertar_establecimiento
(
	@NomEstable varchar(10),
	@Telefono varchar(50),
	@HoraInicio varchar(50),
	@HoraCierre varchar(50),
	@PagFacebook varchar(50),
	@Longitud Decimal(10,2),
	@Latitud Decimal(10,2),
	@Foto image,
	@IdUsuario int

)
as
INSERT INTO Establecimiento (NomEstable,Telefono,HoraInicio,HoraCierre,PagFacebook,Latitud,Longitud,Foto,IdUsuario) 
VALUES(@NomEstable,@Telefono,@HoraInicio,@HoraCierre,@PagFacebook,@Latitud,@Longitud,@Foto,@IdUsuario)
go
----Actualizar Establecimiento
-- Este procedimiento sirve para actualizar los datos de un establecimiento previamente registrado
Create procedure	actualizar_establecimiento
(
	@IdEstablecimiento int,
	@NomEstable varchar(10),
	@Telefono varchar(50),
	@HoraInicio varchar(50),
	@HoraCierre varchar(50),
	@PagFacebook varchar(50),
	@Longitud Decimal(10,2),
	@Latitud Decimal(10,2),
	@Foto image,
	@IdUsuario int

)
as
UPDATE Establecimiento SET NomEstable =@NomEstable,Telefono =@Telefono,HoraInicio = @HoraInicio,HoraCierre =@HoraCierre
,PagFacebook =@PagFacebook ,Latitud = @Latitud,Longitud = @Longitud,Foto = @Foto,IdUsuario  = @IdUsuario
WHERE idEstablecimiento  = @IdEstablecimiento
Go

--Eliminar Establecimiento --------------------
-- Este procedimiento sirve para eliminar en su totalidad un establecimiento que se encuentre en la base de datos
create procedure eliminar_establecimiento
(
	@IdEstablecimiento int
)
as
DELETE FROM Establecimiento WHERE idEstablecimiento = @IdEstablecimiento
go
--------------------------------Procedimiento Almacenado tipo de servicio-----------------------------------
-- Este procedimiento sirve para agregar un nuevo tipo de servicio en la base de datos
create procedure insertar_tiposervicio
(
	@NombreServicio varchar(50)
)
as
insert into TipoServicio (NombreServicio) values (@NombreServicio)
go
--------Actulizar TipoServicio----------
-- Este procedimiento sirve para actualizar los datos de un tipo de servicio previamente registrado
create procedure actualizar_tiposervicio
(

	@idTipoServ int,
	@NombreServicio varchar(50)
)
as
Update TipoServicio  SET NombreServicio= @NombreServicio 
WHERE idTipoServ = @idTipoServ
go
----------Eliminar TipoServicio---------
-- Este procedimiento sirve para eliminar en su totalidad un tipo de servicio que se encuentre en la base de datos
create procedure eliminar_tiposervicio
(
	@idTipoServ int
)
as
DELETE  FROM TipoServicio WHERE idTipoServ = @idTipoServ
go

--------------------------------Procedimiento Almacenado servicio-----------------------------------
--Insertar servicio
-- Este procedimiento sirve para agregar un nuevo servicio en la base de datos
create procedure insertar_servicios
(
    @NombreServ varchar(30),
	@OfertaServicio varchar(50),
	@PrecioServicio decimal(10,2),
	@DescripServicio varchar(50),
	@Foto image,
	@Popularidad int,
	@idEstablecimiento int,
	@idTipoServi int
)
as
Insert INTO Servicios (NombreServ,OfertaServicio,PreciosServicio,DescripServicio,Foto,Popularidad,idEstablecimiento,idTipoServ)
VALUES(@NombreServ,@OfertaServicio,@PrecioServicio,@DescripServicio,@Foto,@Popularidad,@idEstablecimiento,@idTipoServi) 
go

---ActualizarServicio---
-- Este procedimiento sirve para actualizar los datos de un servicio previamente registrado
create procedure actualizar_servicios
(
	@idServicio int,
	@NombreServ varchar(50),
	@OfertaServicio varchar(50),
	@PrecioServicio decimal(10,2),
	@DescripServicio varchar(50),
	@Foto image,
	@Popularidad int,
	@idEstablecimiento int,
	@idTipoServi int
)
as
UPDATE Servicios  SET NombreServ =@NombreServ, OfertaServicio =  @OfertaServicio,PreciosServicio = @PrecioServicio,
DescripServicio =	@DescripServicio,Foto=@Foto,Popularidad=@Popularidad,idEstablecimiento= @idEstablecimiento,idTipoServ = @idTipoServi
where idServicio = @idServicio
go
-- Este procedimiento sirve para eliminar en su totalidad un servicio que se encuentre en la base de datos
create procedure  eliminar_servicios
(
	@idServicio int
)
as
delete from Servicios where idServicio =@idServicio 
GO



--------------------------------Procedimiento Almacenado tipoSuscripcion-----------------------------------


insert into  TipoSuscripcion (Nombre,Monto,TiempoSuscripcion)  VALUES ('Gratis','0','3') 
go


insert into  TipoSuscripcion (Nombre,Monto,TiempoSuscripcion)  VALUES ('Medium','100','1') 
go

insert into  TipoSuscripcion (Nombre,Monto,TiempoSuscripcion)  VALUES ('Premium','400','6') 
go

insert into  TipoSuscripcion (Nombre,Monto,TiempoSuscripcion)  VALUES ('Gold','1000','12') 
go
-------------insertar tisuscripcion-------
-- Este procedimiento sirve para agregar un nuevo tipo de suscripción en la base de datos
create procedure insertar_tiposuscripcion
(
		@Nombre varchar(50),
		@Monto decimal(10,2),
		@TiempoSuscripcion int
)
as
insert into  TipoSuscripcion (Nombre,Monto,TiempoSuscripcion) 
VALUES (@Nombre,@Monto,@TiempoSuscripcion) 
go

-------------actualizar tisuscripcion-------
-- Este procedimiento sirve para actualizar los datos de un tipo de suscripción previamente registrado
create procedure actualizar_tiposuscripcion
(
		@idSuscripcion int,
		@Nombre varchar(50),
		@Monto decimal(10,2),
		@TiempoSuscripcion int
)
as
update  TipoSuscripcion set Nombre = @Nombre,Monto = @Monto,TiempoSuscripcion = @TiempoSuscripcion
where idSuscripcion = @idSuscripcion
go

-----------------eliminar tiposuscripcion---------
-- Este procedimiento sirve para eliminar en su totalidad un tipo de suscripción que se encuentre en la base de datos
create procedure eliminar_tiposuscripcion
(
	@idSuscripcion int
)
as
delete from TipoSuscripcion WHERE idSuscripcion = @idSuscripcion
go


--------------------------------Procedimiento Almacenado soporte-----------------------------------
-- insertar Soporte
-- Este procedimiento sirve para agregar un nuevo soporte en la base de datos
create procedure insertar_soporte
(
	@Comentario varchar(500),
	@Asunto varchar(50),
	@IdUsuario int
)
as
insert into Soporte (Comentario,Asunto,IdUsuario) 
VALUES (@Comentario,@Asunto,@IdUsuario) 
GO
--Actualizar Soporte-
-- Este procedimiento sirve para actualizar los datos de un soporte previamente registrado
Create procedure actualizar_soporte
(
	@idSoporte int,
	@Comentario varchar(500),
	@Asunto varchar(50),
	@IdUsuario int
)
as
UPDATE Soporte SET Comentario = @Comentario,Asunto= @Asunto,IdUsuario= @IdUsuario
WHERE idSoporte = @IdUsuario
GO
--Eliminar	Soporte-
-- Este procedimiento sirve para eliminar en su totalidad un soporte que se encuentre en la base de datos
Create procedure eliminar_soporte
(
	@idSoporte int 
)
as
delete from Soporte  where idSoporte = @idSoporte
go


--------------------------------Procedimiento Almacenado tipoSitio-----------------------------------
-- Este procedimiento sirve para agregar un nuevo tipo de sitio en la base de datos
create procedure insertar_tipositio 
(
	@NombreSitio varchar(50),
	@DescripcionSitio varchar(50)		
)
as
insert into TipoSitio (NombreSitio,DescripcionSitio) VALUES
 (@NombreSitio,@DescripcionSitio)
go
--Actualizar tipositio
-- Este procedimiento sirve para actualizar los datos de un tipo de sitio previamente registrado
create procedure actualizar_tipositio 
(
	@idTipoSitio int ,
	@NombreSitio varchar(50),
	@DescripcionSitio varchar(50)		
)
as
UPDATE TipoSitio SET NombreSitio = @NombreSitio,DescripcionSitio =  @DescripcionSitio WHERE
idTipoSitio = @idTipoSitio 
go
--Eliminar tipositio
-- Este procedimiento sirve para eliminar en su totalidad un tipo de sitio que se encuentre en la base de datos
create procedure eliminar_tipositio
(
	@idTipoServicio int
)
as
DELETE FROM TipoSitio where idTipoSitio = @idTipoServicio
go

--------------------------------Procedimiento Almacenado Sitio-----------------------------------
--inserta sitio
-- Este procedimiento sirve para agregar un nuevo sitio en la base de datos
create procedure insertar_sitio
(
	@Nombre varchar(50),
	@Descripcion varchar(400),
	@Historia varchar(500),
	@Direccion varchar(50),
	@Longitud decimal(10,2),
	@Latitud decimal(10,2),
	@Foto image,
	@SucesosImp varchar(50),
	@idTipoSitio int
)
as
insert into Sitio (Nombre,Descripcion,Historia,Direccion,Longitud,Latitud,Foto,SucesosImp,idTipoSitio) 
VALUES (@Nombre,@Descripcion,@Historia,@Direccion,@Longitud,@Latitud,@Foto,@SucesosImp,@idTipoSitio)
go
--Actulizar sitio
-- Este procedimiento sirve para actualizar los datos de un sitio previamente registrado
create procedure actualizar_sitio
(
	@IdSitio int,
	@Nombre varchar(50),
	@Descripcion varchar(400),
	@Historia varchar(500),
	@Direccion varchar(50),
	@Longitud decimal(10,2),
	@Latitud decimal(10,2),
	@Foto image,
	@SucesosImp varchar(50),
	@idTipoSitio int
)
as
UPDATE  Sitio  SET Nombre = @Nombre,Descripcion = @Descripcion
,Historia = @Historia,Direccion = @Direccion,Longitud = @Longitud,Latitud = @Latitud,Foto= @Foto,SucesosImp = @SucesosImp
,idTipoSitio = @idTipoSitio where IdSitio = @IdSitio
go
--eliminar sitio
-- Este procedimiento sirve para eliminar en su totalidad un sitio que se encuentre en la base de datos
create procedure eliminar_sitio
(
	@idSitio int	
)
as
delete  from Sitio where IdSitio = @idSitio
go


--------------------------------Procedimiento Almacenado evento-----------------------------------
--Insertar evento
-- Este procedimiento sirve para agregar un nuevo evento en la base de datos
create procedure insertar_evento
(
	@NombreEvent varchar(50),
	@HoraIncio varchar(50),
	@HoraFinalizacion varchar(50),
	@FechaIncio date,
	@FechaFinalizacion date,
	@Foto image,
	@IdUsuario int,
	@IdSitio int 
)
as
insert into Eventos  (NombreEvent,HoroInicio,HoraFinalizacion,FechaIncio,FechaFinalizacion,Foto,IdUsuario,IdSitio)
VALUES (@NombreEvent,@HoraIncio,@HoraFinalizacion,@FechaIncio,@FechaFinalizacion,@Foto,@IdUsuario,@IdSitio)
go
--actualizar  evento
-- Este procedimiento sirve para actualizar los datos de un evento previamente registrado
create procedure actualizar_evento
(
	@idEvento int ,
	@NombreEvent varchar(50),
	@HoraIncio varchar(50),
	@HoraFinalizacion varchar(50),
	@FechaIncio date,
	@FechaFinalizacion date,
	@Foto image,
	@IdUsuario int,
	@IdSitio int 
)
as
UPDATE Eventos SET  
NombreEvent = @NombreEvent,HoroInicio = @HoraIncio,
HoraFinalizacion = @HoraFinalizacion,FechaIncio = @FechaIncio,FechaFinalizacion = @FechaFinalizacion,Foto=@Foto
,IdUsuario = @IdUsuario,IdSitio = @IdSitio WHERE idEvento= @idEvento
go
--actualizar  evento
-- Este procedimiento sirve para eliminar en su totalidad un evento que se encuentre en la base de datos
create procedure eliminar_evento
(
	@idEvento int
)
as
delete from Eventos where idEvento =@idEvento
go

--------------------------------Procedimiento Almacenado Notificaciones-----------------------------------
--InsertarNotificacines 
-- Este procedimiento sirve para agregar una nueva notificación en la base de datos
create procedure insertar_notificaciones 
(
	 @idEvento int 
)
as
insert into Notificaciones (idEvento) values (@idEvento)
go
--Modificar notificaciones 
-- Este procedimiento sirve para actualizar los datos de una notificación previamente registrado
create procedure actualizar_notificaciones 
(
	@idNotificaciones int,
	 @idEvento int 
)
as
UPDATE Notificaciones SET idEvento = @idEvento WHERE idNotificacion = @idNotificaciones
go
--eliminar notifiaciones 
-- Este procedimiento sirve para eliminar en su totalidad una notificación que se encuentre en la base de datos
create procedure eliminar_notificaciones
(
 @idNotificaciones int
)
as
delete from Notificaciones where idNotificacion = @idNotificaciones
go


--------------------------------Procedimiento Almacenado Contactanos-----------------------------------
--InsertarContactanos 
-- Este procedimiento sirve para agregar un nuevo registro de contacto en la base de datos
create proc insertar_contactanos
(
	@Nombre varchar(20),
	@Apellidos varchar(20),
	@Email varchar(40),
	@Asunto  varchar(30),
	@Contenido varchar(200)
)
as
insert into Contactanos (Nombre,Apellido,Email,Asunto,Contenido) 
VALUES (@Nombre,@Apellidos,@Email,@Asunto,@Contenido)
GO
--ActualizarContactanos 
-- Este procedimiento sirve para actualizar los datos de un contacto previamente registrado
Create proc actualizar_contactanos
(
	@IdContactanos int,
	@Nombre varchar(20),
	@Apellidos varchar(20),
	@Email varchar(40),
	@Asunto  varchar(30),
	@Contenido varchar(200)
)
as
UPDATE Contactanos SET Nombre = @Nombre , Apellido = @Apellidos, Email = @Email,Asunto =@Asunto,
Contenido = @Contenido WHERE IdContactanos = @IdContactanos
GO
--EliminarContactanos 
-- Este procedimiento sirve para eliminar en su totalidad un registro de contacto que se encuentre en la base de datos
Create proc eliminar_contantanos
(
	@IdContactanos  int
)
as
Delete from Contactanos where IdContactanos = @IdContactanos
go

-----------------------------Procedimiento Almacenado Suscripcion --------------------------------
--InsertarSuscripcion
-- Este procedimiento sirve para agregar una nueva suscripción en la base de datos
create proc insertar_Suscripcion
(
	@idSuscripcion int,
	@FechaPago date,
	@IdUsuario int
	
)
as
insert into Suscripcion (idSuscripcion,FechaPago,IdUsuario) 
VALUES (@idSuscripcion,@FechaPago,@IdUsuario)
GO
--ActualizarSuscripcion
-- Este procedimiento sirve para actualizar los datos de una suscripción previamente registrado
Create proc actualizar_suscripcion
(
	@idSuscripcion int,
	@FechaPago date,
	@IdUsuario int
	
)
as
UPDATE Suscripcion SET FechaPago = @FechaPago, IdUsuario =@IdUsuario  WHERE idSuscripcion = @idSuscripcion
GO
--EliminarContactanos 
-- Este procedimiento sirve para eliminar en su totalidad una suscripción que se encuentre en la base de datos
Create proc eliminar_suscripcion
(
	@idSuscripcion  int
)
as
Delete from Suscripcion where idSuscripcion = @idSuscripcion
go

---------------------------Procedimiento almacenado comentarios ------------------------
--InsertarComentarios
-- Este procedimiento sirve para agregar un nuevo comentario en la base de datos
create proc insertar_comentarios
(
	@Nombre varchar(50),
	@Contenido varchar(100),
	@Status int,
	@IdUsuario int
	
)
as
insert into Comentarios (Nombre,Contenido,Status,IdUsuario) 
VALUES (@Nombre,@Contenido,@Status,@IdUsuario)
GO
--ActualizarComentario
-- Este procedimiento sirve para actualizar los datos de un comentario previamente registrado
Create proc actualizar_comentarios
(
	@IdComentario int,
	@Nombre varchar(50),
	@Contenido varchar(100),
	@Status int,
	@IdUsuario int
	
)
as
UPDATE Comentarios SET Nombre=@Nombre, Contenido=@Contenido, Status = @Status, IdUsuario = @IdUsuario WHERE IdComentario = @IdComentario
GO
--EliminarComentario 
-- Este procedimiento sirve para eliminar en su totalidad un comentario que se encuentre en la base de datos
Create proc eliminar_comentario
(
	@IdComentario  int
)
as
Delete from Comentarios where IdComentario = @IdComentario
go
------------------------------Login User------------------------------
-- Este procedimiento sirve para identificar qué administrador está logueandose en el sistema 
create proc login_user
@email varchar(20),
@password varchar(20)
as
select  Nombre  , IdAdministrador 
from  Administrador
where Email=@email and Contrasena=@password
go

