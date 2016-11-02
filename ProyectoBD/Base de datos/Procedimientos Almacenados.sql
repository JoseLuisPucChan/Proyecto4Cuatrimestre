--Procedimiento Almacenado Adminstrador
--Insetar Administrador
--Select * From Administrador
CREATE PROC insertar_administrador
(
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento date
)
as
INSERT INTO Administrador (Nombre,Apellidos,Email,Contrasena,TelefonoCelular,FechaNacimiento) 
VALUES (@Nombre,@Apellidos,@Email,@Contrasena,@TelefonoCelular,@FechaNacimiento)
Go
--Actualizar Administrador

CREATE PROC actualizar_administrador
(
	@IdAdminstrador int,
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento date
)
as
UPDATE Administrador 
SET Nombre = @Nombre,Apellidos= @Apellidos,Email = @Email,Contrasena = @Contrasena,TelefonoCelular = @TelefonoCelular,FechaNacimiento= @FechaNacimiento 
WHERE IdAdministrador = @IdAdminstrador
Go
--Eliminar Administrador

Create proc eliminar_administrador
(
	@IdAdministrador int
)
as
DELETE FROM Administrador WHERE IdAdministrador = @IdAdministrador
GO

EXEC insertar_administrador 'JOSE','Puc','josechan211@gmail.com','12345','999135','1996-07-29'

EXEC actualizar_administrador 1, 'JOSE','Puc','PRIMO@HOTMAIL','12345','999135','1996-07-29'

EXEC eliminar_administrador 1
go

--Procedimiento Almacenado usuario
--Select * from Usuario
--Insetar Administrador

CREATE PROC insertar_usuario
(
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento date
)
as
INSERT INTO Usuario(Nombre,Apellidos,Email,Contrasena,TelefonoCelular,FechaNacimiento) 
VALUES (@Nombre,@Apellidos,@Email,@Contrasena,@TelefonoCelular,@FechaNacimiento)
Go


--Actualizar usuario

CREATE PROC actualizar_usuario
(
	@IdUsuario int,
	@Nombre varchar(25),
	@Apellidos varchar(25),
	@Email varchar(50),
	@Contrasena varchar(20),
	@TelefonoCelular   varchar(25),
	@FechaNacimiento date
)
as
UPDATE Usuario 
SET Nombre = @Nombre,Apellidos= @Apellidos,Email = @Email,Contrasena = @Contrasena,TelefonoCelular = @TelefonoCelular,FechaNacimiento= @FechaNacimiento 
WHERE IdUsuario = @IdUsuario
Go
--Eliminar usuario

Create proc eliminar_usaurio
(
	@IdUsuario int
)
as
DELETE FROM Usuario WHERE IdUsuario = @IdUsuario
GO

EXEC insertar_usuario'JOSE','Puc','josechan211@gmail.com','12345','999135','1996-07-29'

EXEC actualizar_usuario 1, 'JOSE','Puc','PRIMO@HOTMAIL','12345','999135','1996-07-29'

EXEC eliminar_usaurio 1
go

--Procedimiento Almacenado usuario
Select * from Direccion
go
--Insetar Administrador

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

create procedure eliminar_direccion
(
	@idDireccion int
)
as
Delete from Direccion where idDireccion = @idDireccion
go
exec insertar_direccion '65','43 Y 54','324','Es una casa','Miraflores','Yucatan', '97520',Null, '2'
go

exec eliminar_direccion 7
go



--------------------------------Procedimiento Almacenado establecimiento-----------------------------------
----Insertar Establecimiento
Create procedure insertar_establecimiento
(
	@NomEstable varchar(10),
	@Telefono varchar(50),
	@HoraInicio varchar(50),
	@HoraCierre varchar(50),
	@PagFacebook varchar(50),
	@Longitud Decimal(10,2),
	@Latitud Decimal(10,2),
	@IdUsuario int

)
as
INSERT INTO Establecimiento (NomEstable,Telefono,HoraInicio,HoraCierre,PagFacebook,Latitud,Longitud,IdUsuario) 
VALUES(@NomEstable,@Telefono,@HoraInicio,@HoraCierre,@PagFacebook,@Latitud,@Longitud,@IdUsuario)
go
----Actualizar Establecimiento

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
	@IdUsuario int

)
as
UPDATE Establecimiento SET NomEstable =@NomEstable,Telefono =@Telefono,HoraInicio = @HoraInicio,HoraCierre =@HoraCierre
,PagFacebook =@PagFacebook ,Latitud = @Latitud,Longitud = @Longitud,IdUsuario  = @IdUsuario
WHERE idEstablecimiento  = @IdEstablecimiento
Go

--Eliminar Establecimiento --------------------

create procedure eliminar_establecimiento
(
	@IdEstablecimiento int
)
as
DELETE FROM Establecimiento WHERE idEstablecimiento = @IdEstablecimiento
go


--------------------------------Procedimiento Almacenado tipo de servicio-----------------------------------
create procedure insertar_tiposervicio
(
	@NombreServicio varchar(50)
)
as
insert into TipoServicio (NombreServicio) values (@NombreServicio)
go
--------Actulizar TipoServicio----------
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
create procedure eliminar_tiposervicio
(
	@idTipoServ int
)
as
DELETE  FROM TipoServicio WHERE idTipoServ = @idTipoServ
go




--------------------------------Procedimiento Almacenado servicio-----------------------------------
--Insertar servicio
create procedure insertar_servicios
(
	@OfertaServicio varchar(50),
	@PrecioServicio decimal(10,2),
	@DescripServicio varchar(50),
	@idEstablecimiento int,
	@idTipoServi int
)
as
Insert INTO Servicios (OfertaServicio,PreciosServicio,DescripServicio,idEstablecimiento,idTipoServ)
VALUES(@OfertaServicio,@PrecioServicio,@DescripServicio,@idEstablecimiento,@idTipoServi) 
go

---ActualizarServicio---

create procedure actualizar_servicios
(
	@idServicio int,
	@OfertaServicio varchar(50),
	@PrecioServicio decimal(10,2),
	@DescripServicio varchar(50),
	@idEstablecimiento int,
	@idTipoServi int
)
as
UPDATE Servicios  SET OfertaServicio =  @OfertaServicio,PreciosServicio = @PrecioServicio,
DescripServicio =	@DescripServicio,idEstablecimiento= @idEstablecimiento,idTipoServ = @idTipoServi
where idServicio = @idServicio
go

create procedure  eliminar_servicios
(
	@idServicio int
)
as
delete from Servicios where idServicio =@idServicio 
GO



--------------------------------Procedimiento Almacenado tipoSuscripcion-----------------------------------

-------------insertar tisuscripcion-------
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
create procedure eliminar_tiposuscripcion
(
	@idSuscripcion int
)
as
delete from TipoSuscripcion WHERE idSuscripcion = @idSuscripcion
go


--------------------------------Procedimiento Almacenado soporte-----------------------------------
-- insertar Soporte

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
Create procedure eliminar_soporte
(
	@idSoporte int 
)
as
delete from Soporte  where idSoporte = @idSoporte
go


--------------------------------Procedimiento Almacenado tipoSitio-----------------------------------
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

create procedure eliminar_tipositio
(
	@idTipoServicio int
)
as
DELETE FROM TipoSitio where idTipoSitio = @idTipoServicio
go

--------------------------------Procedimiento Almacenado Sitio-----------------------------------
--inserta sitio
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
create procedure eliminar_sitio
(
	@idSitio int	
)
as
delete  from Sitio where IdSitio = @idSitio
go


--------------------------------Procedimiento Almacenado evento-----------------------------------
--Insertar evento
create procedure insertar_evento
(
	@NombreEvent varchar(50),
	@HoraIncio varchar(50),
	@HoraFinalizacion varchar(50),
	@FechaIncio date,
	@FechaFinalizacion date,
	@IdUsuario int,
	@IdSitio int 
)
as
insert into Eventos  (NombreEvent,HoroInicio,HoraFinalizacion,FechaIncio,FechaFinalizacion,IdUsuario,IdSitio)
VALUES (@NombreEvent,@HoraIncio,@HoraFinalizacion,@FechaIncio,@FechaFinalizacion,@IdUsuario,@IdSitio)
go
--actualizar  evento
create procedure actualizar_evento
(
	@idEvento int ,
	@NombreEvent varchar(50),
	@HoraIncio varchar(50),
	@HoraFinalizacion varchar(50),
	@FechaIncio date,
	@FechaFinalizacion date,
	@IdUsuario int,
	@IdSitio int 
)
as
UPDATE Eventos SET  
NombreEvent = @NombreEvent,HoroInicio = @HoraIncio,
HoraFinalizacion = @HoraFinalizacion,FechaIncio = @FechaIncio,FechaFinalizacion = @FechaFinalizacion
,IdUsuario = @IdUsuario,IdSitio = @IdSitio WHERE idEvento= @idEvento
go
--actualizar  evento
create procedure eliminar_evento
(
	@idEvento int
)
as
delete from Eventos where idEvento =@idEvento
go

--------------------------------Procedimiento Almacenado Notificaciones-----------------------------------
--InsertarNotificacines 
create procedure insertar_notificaciones 
(
	 @idEvento int 
)
as
insert into Notificaciones (idEvento) values (@idEvento)
go


--Modificar notificaciones 
create procedure actualizar_notificaciones 
(
	@idNotificaciones int,
	 @idEvento int 
)
as
UPDATE Notificaciones SET idEvento = @idEvento WHERE idNotificacion = @idNotificaciones
go



--eliminar notifiaciones 
create procedure eliminar_notificaciones
(
 @idNotificaciones int
)
as
delete from Notificaciones where idNotificacion = @idNotificaciones
go




