--------------------Funci�n para encriptar contrase�a
CREATE FUNCTION fnColocaClave 
(
    @clave VARCHAR(25)
)
RETURNS VarBinary(8000)
AS
BEGIN
    DECLARE @pass AS VarBinary(8000)
    SET @pass = ENCRYPTBYPASSPHRASE('dbCurso09',@clave)
    RETURN @pass

END
go
--------------------Funci�n para desencriptar contrase�a
CREATE FUNCTION fnLeeClave 
(
    @clave VARBINARY(8000)
)
RETURNS VARCHAR(25)
AS
BEGIN
    DECLARE @pass AS VARCHAR(25)
    SET @pass = DECRYPTBYPASSPHRASE('dbCurso09',@clave)
    RETURN @pass

END
GO

------------------para ver encriptada la contrase�a
SELECT IdUsuario, nombre, apellidos, email, dbo.fnColocaClave(contrasena) as [Contrase�a]
FROM Usuario
GO

------------------para desifrar contrase�a
SELECT IdUsuario, nombre, apellidos, email, dbo.fnLeeClave(contrasena) as [Contrase�a]
FROM Usuario
GO
-----------------------enviarcorreos
EXEC msdb.dbo.sp_send_dbmail
    @profile_name = 'Jos� Luis',
    @recipients = 'josecha211@gmail.com',
    @body = 'La prueba funciono satisfactoriamente',
    @subject = 'Importante' ;
GO


-----------Creamos el procedimiento almacenado para poder hacer el backup con la fecha y hora.
------------Creare un ejemplo con la base de datos de mi proyecto MCTurisctic

Declare @fecha varchar(MAX)
Declare @archivo varchar(Max)
set @fecha = CONVERT(varchar(Max),GETDATE(),102)+'_'+SUBSTRING(CONVERT(varchar(10),GETDATE(),108),4,2)+'Horas' 
set @archivo = 'C:\BackcupMCTuristic\MCTuristic'+@fecha+'.bak'
BACKUP DATABASE  [MCTuristic] TO DISK = @archivo WITH FORMAT,
MEDIANAME = 'D_SQLServerBackups', NAME = 'FULL Backup';
Go
---------------------Declarada ahora generemos la automatizaci�n

---- creaci�n de nuevos inicios de sesi�n y usuarios
CREATE LOGIN AdministradorNuevo WITH PASSWORD = '123'
CREATE USER AdministradorNuevo FOR LOGIN AdministradorNuevo
GO
CREATE LOGIN UsuarioNuevo WITH PASSWORD = '123'
CREATE USER UsuarioNuevo FOR LOGIN UsuarioNuevo
GO

---- Conceder permisos de administrador a un usuario de windows
sp_addsrvrolemember 'AdministradorNuevo', 'sysadmin'
go

---- Creaci�n de una base de datos con autorizaciones para los usuarios: UsuarioNuevo y AdministradorNuevo
CREATE DATABASE Jardin
go
use Jardin
go
CREATE SCHEMA Verde AUTHORIZATION AdministradorNuevo
go
CREATE TABLE Plantas (
idPlanta INT IDENTITY(1,1)
,Descripcion NVARCHAR(100)
,Estatus CHAR(1)
,CONSTRAINT [PK_Planta] PRIMARY KEY (idPlanta)
)
GRANT SELECT, INSERT ON Jardin.Plantas TO UsuarioNuevo
GO

