/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      MascotasExtravidas
 * Project :      MoldeLogicoProyecto4B.DM1
 * Author :       Luis Puc
 *
 * Date Created : Sunday, November 20, 2016 12:27:07
 * Target DBMS : Microsoft SQL Server 2008
 */
 
 CREATE DATABASE MCTuristic;
GO

USE MCTuristic;
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
    FechaNacimiento    date           NOT NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (IdAdministrador)
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
    Contenido       varchar(100)    NOT NULL,
    Status          int             NOT NULL,
    IdUsuario       int             NULL,
    CONSTRAINT PK18 PRIMARY KEY NONCLUSTERED (IdComentario)
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
    Nombre           varchar(20)     NOT NULL,
    Apellido         varchar(20)     NOT NULL,
    Email            varchar(40)     NOT NULL,
    Asunto           varchar(30)     NOT NULL,
    Contenido        varchar(200)    NOT NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (IdContactanos)
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
    IdAdministrador    int            NULL,
    CONSTRAINT PK15 PRIMARY KEY NONCLUSTERED (idDireccion)
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
    idEstablecimiento    int               IDENTITY(1,1),
    NomEstable           varchar(10)       NOT NULL,
    Telefono             varchar(50)       NOT NULL,
    HoraInicio           varchar(50)       NOT NULL,
    HoraCierre           varchar(50)       NOT NULL,
    PagFacebook          varchar(50)       NOT NULL,
    Longitud             decimal(10, 2)    NOT NULL,
    Latitud              decimal(10, 2)    NOT NULL,
    Foto                 image             NOT NULL,
    IdUsuario            int               NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (idEstablecimiento)
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
    IdSitio              int            NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (idEvento)
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
    idEvento          int    NOT NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (idNotificacion)
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
    DescripServicio      varchar(50)       NOT NULL,
    Foto                 image             NOT NULL,
    Popularidad          int               NOT NULL,
    idEstablecimiento    int               NOT NULL,
    idTipoServ           int               NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (idServicio)
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
    IdSitio        int               IDENTITY(1,1),
    Nombre         varchar(50)       NOT NULL,
    Descripcion    varchar(400)      NOT NULL,
    Historia       varchar(500)      NOT NULL,
    Direccion      varchar(50)       NOT NULL,
    Longitud       decimal(10, 2)    NOT NULL,
    Latitud        decimal(10, 2)    NOT NULL,
    Foto           image             NOT NULL,
    SucesosImp     varchar(50)       NOT NULL,
    idTipoSitio    int               NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (IdSitio)
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
    Comentario    varchar(500)    NOT NULL,
    Asunto        varchar(50)     NOT NULL,
    IdUsuario     int             NOT NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (idSoporte)
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
    NombreServicio    varchar(50)    NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (idTipoServ)
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
    DescripcionSitio    varchar(50)    NOT NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (idTipoSitio)
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
    TiempoSuscripcion    int               NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idSuscripcion)
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
    Foto               image          NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (IdUsuario)
)
go



IF OBJECT_ID('Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuario >>>'
go

/* 
 * TABLE: Comentarios 
 */

ALTER TABLE Comentarios ADD CONSTRAINT RefUsuario25 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go


/* 
 * TABLE: Direccion 
 */

ALTER TABLE Direccion ADD CONSTRAINT RefUsuario15 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go

ALTER TABLE Direccion ADD CONSTRAINT RefAdministrador23 
    FOREIGN KEY (IdAdministrador)
    REFERENCES Administrador(IdAdministrador)
go


/* 
 * TABLE: Establecimiento 
 */

ALTER TABLE Establecimiento ADD CONSTRAINT RefUsuario6 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go


/* 
 * TABLE: Eventos 
 */

ALTER TABLE Eventos ADD CONSTRAINT RefUsuario9 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go

ALTER TABLE Eventos ADD CONSTRAINT RefSitio10 
    FOREIGN KEY (IdSitio)
    REFERENCES Sitio(IdSitio)
go


/* 
 * TABLE: Notificaciones 
 */

ALTER TABLE Notificaciones ADD CONSTRAINT RefEventos13 
    FOREIGN KEY (idEvento)
    REFERENCES Eventos(idEvento)
go


/* 
 * TABLE: Servicios 
 */

ALTER TABLE Servicios ADD CONSTRAINT RefEstablecimiento7 
    FOREIGN KEY (idEstablecimiento)
    REFERENCES Establecimiento(idEstablecimiento)
go

ALTER TABLE Servicios ADD CONSTRAINT RefTipoServicio8 
    FOREIGN KEY (idTipoServ)
    REFERENCES TipoServicio(idTipoServ)
go


/* 
 * TABLE: Sitio 
 */

ALTER TABLE Sitio ADD CONSTRAINT RefTipoSitio11 
    FOREIGN KEY (idTipoSitio)
    REFERENCES TipoSitio(idTipoSitio)
go


/* 
 * TABLE: Soporte 
 */

ALTER TABLE Soporte ADD CONSTRAINT RefUsuario22 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go


/* 
 * TABLE: Suscripcion 
 */

ALTER TABLE Suscripcion ADD CONSTRAINT RefTipoSuscripcion4 
    FOREIGN KEY (idSuscripcion)
    REFERENCES TipoSuscripcion(idSuscripcion)
go

ALTER TABLE Suscripcion ADD CONSTRAINT RefUsuario5 
    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
go


