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





