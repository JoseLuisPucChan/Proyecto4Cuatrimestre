-------------Vistas-----------------
CREATE VIEW mostrar_Administrador
as
SELECT			Adm.IdAdministrador,  Adm.Nombre, Adm.Apellidos, 
				Adm.Email, Adm.TelefonoCelular, Adm.FechaNacimiento, 
				D.idDireccion ,
				D.Calle, D.Cruzamiento, 
				D.Numero, D.Colonia,
				D.Descripcion, D.Estado, D.CodPostal
FROM Administrador as Adm 
INNER JOIN
Direccion as D ON D.IdAdministrador = D.IdAdministrador
GO
CREATE VIEW mostrar_usuarios
as
SELECT				Us.IdUsuario, Us.Nombre, 
					Us.Apellidos, Us.Email, 
					Us.TelefonoCelular, Us.FechaNacimiento, 
					D.Calle,D.idDireccion, 
                    D.Cruzamiento, D.Numero, D.Descripcion, 
					D.Estado, D.CodPostal
FROM  Direccion AS D INNER JOIN
      Usuario as Us ON D.IdUsuario = Us.IdUsuario
GO
CREATE VIEW mostrar_productos
as
SELECT        Es.idEstablecimiento, 
			  Es.NomEstable, Es.HoraInicio, 
			  Es.HoraCierre, Ser.NombreServ, Ser.OfertaServicio, 
              Ser.PreciosServicio, TipSer.NombreServicio
FROM          Establecimiento as Es INNER JOIN
                         Servicios as Ser ON Es.idEstablecimiento = Ser.idEstablecimiento INNER JOIN
                         TipoServicio as TipSer ON Ser.idTipoServ = TipSer.idTipoServ 
GO
CREATE VIEW mostrar_suscripciones
as
SELECT        us.IdUsuario, us.Nombre,us.Apellidos, us.Email, Sp.FechaPago, 
				TpS.Nombre AS TipoSuscripcion, 
				TpS.Monto, 
				 TpS.TiempoSuscripcion
FROM            dbo.Usuario us INNER JOIN
                Suscripcion Sp ON us.IdUsuario = Sp.IdUsuario INNER JOIN
		        TipoSuscripcion as TpS ON Sp.idSuscripcion = TpS.idSuscripcion
GO
CREATE VIEW mostrar_eventos
as
SELECT        St.Nombre,St.Descripcion,St.Direccion, Ev.NombreEvent, Ev.HoroInicio, 
Ev.HoraFinalizacion, Ev.FechaIncio, Ev.FechaFinalizacion, 
                         TpS.NombreSitio
FROM            dbo.Sitio St INNER JOIN
                         TipoSitio as TpS ON St.idTipoSitio = TpS.idTipoSitio INNER JOIN
                         Eventos as Ev ON St.IdSitio = Ev.IdSitio
GO