/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      MascotasExtravidas
 * Project :      MoldeLogicoProyecto4B.DM1
 * Author :       Luis Puc
 *
 * Date Created : Wednesday, November 23, 2016 18:57:07
 * Target DBMS : Microsoft SQL Server 2008
 */

CREATE DATABASE MCTuristic
GO

USE MCTuristic
GO

/* 
 * TABLE: Administrador 
 */

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
 * TABLE: Comentarios 
 */

CREATE TABLE Comentarios(
    IdComentario    int             NOT NULL,
    Nombre          varchar(50)     NOT NULL,
    Contenido       varchar(max)    NOT NULL,
    Status          int             NOT NULL,
    IdUsuario       int             NULL
)
go



IF OBJECT_ID('Comentarios') IS NOT NULL
    PRINT '<<< CREATED TABLE Comentarios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Comentarios >>>'
go

/* 
 * TABLE: Contactanos 
 */

CREATE TABLE Contactanos(
    IdContactanos    int             IDENTITY(1,1),
    Nombre           varchar(30)     NOT NULL,
    Apellido         varchar(20)     NOT NULL,
    Email            varchar(40)     NOT NULL,
    Asunto           varchar(30)     NOT NULL,
    Contenido        varchar(max)    NOT NULL
)
go



IF OBJECT_ID('Contactanos') IS NOT NULL
    PRINT '<<< CREATED TABLE Contactanos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Contactanos >>>'
go

/* 
 * TABLE: Direccion 
 */

CREATE TABLE Direccion(
    idDireccion        int            IDENTITY(1,1),
    Calle              varchar(50)    NOT NULL,
    Cruzamiento        varchar(50)    NOT NULL,
    Numero             varchar(50)    NOT NULL,
    Descripcion        varchar(50)    NOT NULL,
    Colonia            varchar(50)    NOT NULL,
    Estado             varchar(50)    NOT NULL,
    CodPostal          varchar(50)    NOT NULL,
    IdUsuario          int            NULL,
    IdAdministrador    int            NULL
)
go



IF OBJECT_ID('Direccion') IS NOT NULL
    PRINT '<<< CREATED TABLE Direccion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Direccion >>>'
go

/* 
 * TABLE: Establecimiento 
 */

CREATE TABLE Establecimiento(
    idEstablecimiento    int              IDENTITY(1,1),
    NomEstable           varchar(100)     NOT NULL,
    Telefono             varchar(50)      NOT NULL,
    HoraInicio           varchar(50)      NOT NULL,
    HoraCierre           varchar(50)      NOT NULL,
    PagFacebook          varchar(50)      NOT NULL,
    Longitud             decimal(7, 7)    NOT NULL,
    Latitud              decimal(7, 7)    NOT NULL,
    Foto                 image            NOT NULL,
    IdUsuario            int              NOT NULL
)
go



IF OBJECT_ID('Establecimiento') IS NOT NULL
    PRINT '<<< CREATED TABLE Establecimiento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Establecimiento >>>'
go

/* 
 * TABLE: Eventos 
 */

CREATE TABLE Eventos(
    idEvento             int            IDENTITY(1,1),
    NombreEvent          varchar(50)    NOT NULL,
    HoroInicio           varchar(50)    NOT NULL,
    HoraFinalizacion     varchar(50)    NOT NULL,
    FechaIncio           date           NOT NULL,
    FechaFinalizacion    date           NOT NULL,
    Foto                 image          NOT NULL,
    IdUsuario            int            NOT NULL,
    IdSitio              int            NOT NULL
)
go



IF OBJECT_ID('Eventos') IS NOT NULL
    PRINT '<<< CREATED TABLE Eventos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Eventos >>>'
go

/* 
 * TABLE: Notificaciones 
 */

CREATE TABLE Notificaciones(
    idNotificacion    int    IDENTITY(1,1),
    idEvento          int    NOT NULL
)
go



IF OBJECT_ID('Notificaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE Notificaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Notificaciones >>>'
go

/* 
 * TABLE: Servicios 
 */

CREATE TABLE Servicios(
    idServicio           int               IDENTITY(1,1),
    NombreServ           varchar(30)       NOT NULL,
    OfertaServicio       varchar(50)       NOT NULL,
    PreciosServicio      decimal(10, 2)    NOT NULL,
    DescripServicio      varchar(max)       NOT NULL,
    Foto                 image             NOT NULL,
    Popularidad          int               NOT NULL,
    idEstablecimiento    int               NOT NULL,
    idTipoServ           int               NOT NULL
)
go



IF OBJECT_ID('Servicios') IS NOT NULL
    PRINT '<<< CREATED TABLE Servicios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Servicios >>>'
go

/* 
 * TABLE: Sitio 
 */

CREATE TABLE Sitio(
    IdSitio        int              IDENTITY(1,1),
    Nombre         varchar(100)     NOT NULL,
    Descripcion    varchar(max)     NOT NULL,
    Historia       varchar(max)     NOT NULL,
    Direccion      varchar(50)      NOT NULL,
    Longitud       decimal(7, 7)    NOT NULL,
    Latitud        decimal(7, 7)    NOT NULL,
    Foto           image            NOT NULL,
    SucesosImp     varchar(max)      NOT NULL,
    idTipoSitio    int              NOT NULL
)
go



IF OBJECT_ID('Sitio') IS NOT NULL
    PRINT '<<< CREATED TABLE Sitio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Sitio >>>'
go

/* 
 * TABLE: Soporte 
 */

CREATE TABLE Soporte(
    idSoporte     int             IDENTITY(1,1),
    Comentario    varchar(max)    NOT NULL,
    Asunto        varchar(50)     NOT NULL,
    IdUsuario     int             NOT NULL
)
go



IF OBJECT_ID('Soporte') IS NOT NULL
    PRINT '<<< CREATED TABLE Soporte >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Soporte >>>'
go

/* 
 * TABLE: Suscripcion 
 */

CREATE TABLE Suscripcion(
    idSuscripcion    int     NOT NULL,
    FechaPago        date    NOT NULL,
    IdUsuario        int     NOT NULL
)
go



IF OBJECT_ID('Suscripcion') IS NOT NULL
    PRINT '<<< CREATED TABLE Suscripcion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Suscripcion >>>'
go

/* 
 * TABLE: TipoServicio 
 */

CREATE TABLE TipoServicio(
    idTipoServ        int            IDENTITY(1,1),
    NombreServicio    varchar(50)    NOT NULL
)
go



IF OBJECT_ID('TipoServicio') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoServicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoServicio >>>'
go

/* 
 * TABLE: TipoSitio 
 */

CREATE TABLE TipoSitio(
    idTipoSitio         int            IDENTITY(1,1),
    NombreSitio         varchar(50)    NOT NULL,
    DescripcionSitio    varchar(50)    NOT NULL
)
go



IF OBJECT_ID('TipoSitio') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoSitio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoSitio >>>'
go

/* 
 * TABLE: TipoSuscripcion 
 */

CREATE TABLE TipoSuscripcion(
    idSuscripcion        int               IDENTITY(1,1),
    Nombre               varchar(50)       NOT NULL,
    Monto                decimal(10, 2)    NOT NULL,
    TiempoSuscripcion    int               NOT NULL
)
go



IF OBJECT_ID('TipoSuscripcion') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoSuscripcion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoSuscripcion >>>'
go

/* 
 * TABLE: Usuario 
 */

CREATE TABLE Usuario(
    IdUsuario          int            IDENTITY(1,1),
    Nombre             varchar(50)    NOT NULL,
    Apellidos          varchar(50)    NOT NULL,
    Email              varchar(50)    NOT NULL,
    Contrasena         varchar(20)    NOT NULL,
    TelefonoCelular    varchar(50)    NOT NULL,
    FechaNacimiento    date           NOT NULL,
    Foto               image          NOT NULL
)
go



IF OBJECT_ID('Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuario >>>'
go

