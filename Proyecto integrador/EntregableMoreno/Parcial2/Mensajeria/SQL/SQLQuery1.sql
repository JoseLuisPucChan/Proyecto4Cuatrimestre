--Use master
--DROP DATABASE Mensajeria


create database Mensajeria
go 

use Mensajeria

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

create table Alumno (
AlumnoID [int] IDENTITY(1,1) not null,
Nombre [Varchar](30) not null,
Semestre [int] not null,
Usuario [Varchar](10) unique not null, 
Contrasenia [Varchar](20) not null

 CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
 ( [AlumnoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
/* IGNORE_DUP_KEY = OFF Afirma que si la llave primaria se duplica regresara El insert y mostrara un arror EVITA LLAVES PRIMARIAS REPETIDAS*/
) ON [PRIMARY]
SET ANSI_NULLS ON
GO


SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
--select * from Mensaje 

create table Mensaje (
MensajeID [int] IDENTITY(1,1) not null,
Mensaje[Varchar](168),
Destinatario [Varchar](30),
Asunto [Varchar](50)


 CONSTRAINT [PK2] PRIMARY KEY NONCLUSTERED 
 ( [MensajeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
)ON [PRIMARY]



create table AlumnoMensaje (
AlumnoID [int] not null ,
MensajeID [int]  not null
 

CONSTRAINT FK_AlumnoID FOREIGN KEY (AlumnoID) REFERENCES Alumno(AlumnoID),
CONSTRAINT FK_MensajeID FOREIGN KEY (MensajeID) REFERENCES Mensaje(MensajeID)
 
 ) 
SET ANSI_NULLS ON


/* Procedures Alumnos*/
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarAlumno]
(
		
		@Usuario varchar(20)=null,
		@Nombre varchar(20)=null,
		@Semestre  varchar(20)=null,
		@Contrasenia varchar(20) = null
		
)
AS
 insert into Alumno (Nombre , Semestre , Usuario, Contrasenia)  
 values (@Nombre,@Semestre, @Usuario , @Contrasenia )
 
GO
exec AgregarAlumno 'Admin' , Administrador,0 , 'Admin'

SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ModifcarAlumno]
(
		@AlumnoID int=null,
		@Usuario varchar(20)=null,
		@Nombre varchar(20)=null,
		@Semestre  varchar(20)=null,
		@Contrasenia varchar(20) = null
)
AS
SET NOCOUNT ON
UPDATE Alumno
SET 

	 Usuario =	@Usuario ,
	 Nombre = @Nombre ,
	 Semestre =	@Semestre ,
	 Contrasenia=@Contrasenia

WHERE  (AlumnoID = @AlumnoID)
GO



SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[EliminarAlumno]
(
		@AlumnoID int=null	
)
AS
delete Alumno WHERE (AlumnoID = @AlumnoID)
GO


SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[FiltrarAlumno] 
	(		
		@AlumnoID int=null,
		@Usuario varchar(20)=null,
		@Nombre varchar(20)=null,
		@Semestre  varchar(20)=null
		
		--@debug     bit          = 0 AS 
	)
AS
	SET NOCOUNT ON

	DECLARE @sql nvarchar(4000)
	SET @sql = ' SELECT * FROM Alumno where 1 = 1 '
		
	if(@AlumnoID <> 0)	
		SET @sql=@sql+ ' and AlumnoID = '+convert(varchar,@AlumnoID)
	if(@Usuario <> '')	
		SET @sql= @sql+ ' and Usuario = '+Quotename(@Usuario,'''') 
	if(@Nombre <> '')	
		SET @sql=@sql+ ' and Nombre = '+Quotename(@Nombre,'''') 
	if(@Semestre <>0)	
		SET @sql=@sql+ ' and Semestre  = '+convert(varchar,@Semestre)

	exec (@sql)
GO




SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  DevolverTablaAlumnos 
	as 
	DECLARE @sql nvarchar(25)
	SET @sql = ' SELECT * FROM Alumno where 1 = 1 '
		
	

	exec (@sql)
GO




/* Procedures Mensajes */


CREATE PROCEDURE [dbo].[AgregarMensaje]
(
		
		@Mensaje Varchar(168)
)
AS
 insert into Mensaje (Mensaje)  
 values (@Mensaje)
SET ANSI_NULLS ON
GO


CREATE PROCEDURE [dbo].[FiltrarMesaje]
(
       
		@AlumnoID int = null
)
AS 
SET NOCOUNT ON
DECLARE @sql nvarchar(4000)
SET @sql = 'SELECT * FROM Mensaje WHERE 1=1 '

	If(@AlumnoID <> 0)
		SET @sql = @sql+ 'AND MensajeID in ( select MensajeID from AlumnoMensaje where AlumnoID = '+convert(varchar,@AlumnoID) + ')'
		
	exec (@sql)
	
	go


 CREATE PROCEDURE EnviarMensaje
 (
        
		@AlumnoID int = null,
		@Mensaje varchar(168),
		@Destinatario varchar(30),
		@Asunto varchar(50)
)
AS 
SET NOCOUNT ON


 insert into Mensaje (Mensaje,Destinatario, Asunto ) values (@Mensaje , @Destinatario , @Asunto)
 insert into AlumnoMensaje (MensajeID , AlumnoID) values ( (select Top 1 MensajeID from Mensaje order by MensajeID DESC) , @AlumnoID)

 go

 CREATE PROCEDURE validarEntrada
 (
    @Usuario varchar(30),
	@Contrasenia varchar(20)
 )
 AS
 SET NOCOUNT ON
 DECLARE @sql nvarchar(4000)
SET @sql = 'SELECT * FROM Alumno WHERE 1=1 '

	
		SET @sql = @sql+ 'AND Usuario = '+Quotename(@Usuario,'''') 
		SET @sql = @sql+ 'AND Contrasenia = '+Quotename(@Contrasenia,'''') 
	
	exec (@sql)
	
	go
 

