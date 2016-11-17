/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      MascotasExtravidas
 * Project :      MoldeLogicoProyecto4B.DM1
 * Author :       Luis Puc
 *
 * Date Created : Thursday, November 17, 2016 12:09:53
 * Target DBMS : Microsoft SQL Server 2008
 */

/* 
 * TABLE: Administrador 
 */
 
CREATE DATABASE MCTuristic;
GO

USE MCTuristic;
GO

CREATE TABLE Administrador(
    IdAdministrador    int            IDENTITY(1,1),
    Nombre             varchar(25)    NOT NULL,
    Apellidos          varchar(25)    NOT NULL,
    Email              varchar(50)    NOT NULL,
    Contrasena         varchar(20)    NOT NULL,
    TelefonoCelular    varchar(25)    NOT NULL,
    FechaNacimiento    date           NOT NULL
)
go



IF OBJECT_ID('Administrador') IS NOT NULL
    PRINT '<<< CREATED TABLE Administrador >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Administrador >>>'
go

/* 
 * TABLE: Administrador 
 */

ALTER TABLE Administrador ADD 
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (IdAdministrador)
go

IF OBJECT_ID('Administrador') IS NOT NULL
    PRINT '<<< CREATED TABLE Administrador >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Administrador >>>'
go

