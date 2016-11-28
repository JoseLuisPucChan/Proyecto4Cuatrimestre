-----------Creamos el procedimiento almacenado para poder hacer el backup con la fecha y hora.
------------Creare un ejemplo con la base de datos de mi proyecto MCTurisctic

Declare @fecha varchar(MAX)
Declare @archivo varchar(Max)
set @fecha = CONVERT(varchar(Max),GETDATE(),102)+'_'+SUBSTRING(CONVERT(varchar(10),GETDATE(),108),4,2)+'Horas' 
set @archivo = 'C:\BackcupMCTuristic\MCTuristic'+@fecha+'.bak'
BACKUP DATABASE  [MCTuristic] TO DISK = @archivo WITH FORMAT,
MEDIANAME = 'D_SQLServerBackups', NAME = 'FULL Backup';
Go
---------------------Declarada ahora generemos la automatización

CREATE LOGIN adminMC WITH PASSWORD = '123'
CREATE USER adminMC FOR LOGIN adminMC
GO
CREATE LOGIN usuarioMC WITH PASSWORD = '123'
CREATE USER usuarioMC FOR LOGIN usuarioMC
GO
CREATE SCHEMA Escuela1 AUTHORIZATION adminMC
CREATE TABLE Carrera (
idCarrera INT IDENTITY(1,1)
,Descripcion NVARCHAR(100)
,Estatus CHAR(1)
,CONSTRAINT [PK_Carrera] PRIMARY KEY (idCarrera)
)
CREATE TABLE Materia (
idMateria INT IDENTITY(1,1)
,Descripcion NVARCHAR(100)
,idCarrera INT
,Estatus CHAR(1)
,CONSTRAINT [PK_Materia] PRIMARY KEY (idMateria)
,CONSTRAINT [FK_Materia_Carrera] FOREIGN KEY (idCarrera)
REFERENCES [Carrera] (idCarrera)
)
GRANT SELECT, INSERT ON Escuela1.Carrera TO usuarioMC
GO
CREATE TABLE Escuela1.Maestro(
idMaestro int identity(1,1)
,Nombre nvarchar(100)
,CONSTRAINT [PK_Maestro] PRIMARY KEY (idMaestro)
)