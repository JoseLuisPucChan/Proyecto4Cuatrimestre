EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código único del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'IdAdministrador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellidos del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'Apellidos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Correo electronico del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contraseña del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'Contrasena'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telefono Movil del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'TelefonoCelular'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contraseña del administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador', @level2type=N'COLUMN',@level2name=N'FechaNacimiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre los administradores de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador unico del comentario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios', @level2type=N'COLUMN',@level2name=N'IdComentario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contenido del comentario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios', @level2type=N'COLUMN',@level2name=N'Contenido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'determina el estado si es publicado o no' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador unico del usuario que emite el Comentario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre los comentarios de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Comentarios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador unico del del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'IdContactanos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del emisor del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido del emisor del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'Apellido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email del emisor del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Asunto del emisor del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'Asunto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contenido del mensaje' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos', @level2type=N'COLUMN',@level2name=N'Contenido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre la tabla contactanos de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contactanos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador unico de la direccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'idDireccion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion de la calle en tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Calle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion de los Cruzamientos en tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Cruzamiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion del numero en tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Numero'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion de la decripcion en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion de la Colonia en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Colonia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion del estado en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'Estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion del Codigo Postal en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'CodPostal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion del usuario en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especificacion del Administrador en la tabla dirección' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion', @level2type=N'COLUMN',@level2name=N'IdAdministrador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre la tabla Direccion de los usuarios de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Direccion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador unico del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'idEstablecimiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'NomEstable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teléfono del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'Telefono'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hora de apertura del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'HoraInicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hora de cierre del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'HoraCierre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pagina del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'PagFacebook'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Longitud del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'Longitud'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Latitud del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'Latitud'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foto del Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'Foto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador del Usuario en tabla Establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre los Establecimientos de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Establecimiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador unico del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'idEvento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'NombreEvent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hora de Inicio del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'HoroInicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hora de Finalizacion del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'HoraFinalizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de Incio del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'FechaIncio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de Finalizacion del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'FechaFinalizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foto del evento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'Foto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador del Usuario en la tabla eventos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador del Sitio en la tabla eventos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos', @level2type=N'COLUMN',@level2name=N'IdSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información de los eventos de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Eventos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador de la notificación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notificaciones', @level2type=N'COLUMN',@level2name=N'idNotificacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador del evento en la tabla notificaciones' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notificaciones', @level2type=N'COLUMN',@level2name=N'idEvento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información de las Notificaciones de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notificaciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'idServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'NombreServ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Oferta del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'OfertaServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Precios del servicio del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'PreciosServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción del servicio del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'DescripServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foto del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'Foto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Popularidad del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'Popularidad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del establecimiento del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'idEstablecimiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del tipo del servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios', @level2type=N'COLUMN',@level2name=N'idTipoServ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información de los Servicios que ofrece un establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Servicios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador unico del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'IdSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Descripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Historia del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Historia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Direccion del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Direccion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Longitud del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Longitud'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Latitud del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Latitud'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foto del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'Foto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sucesos Importantes del Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'SucesosImp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del Tipo de sitio  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio', @level2type=N'COLUMN',@level2name=N'idTipoSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre los sitios de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador unico del soporte' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Soporte', @level2type=N'COLUMN',@level2name=N'idSoporte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'comentario sobre el soporte de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Soporte', @level2type=N'COLUMN',@level2name=N'Comentario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'asunto sobre el soporte de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Soporte', @level2type=N'COLUMN',@level2name=N'Asunto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del usario que envia el comentario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Soporte', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre el soporte de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Soporte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador de la suscripción' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Suscripcion', @level2type=N'COLUMN',@level2name=N'idSuscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de pago de la suscripción' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Suscripcion', @level2type=N'COLUMN',@level2name=N'FechaPago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del usuario ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Suscripcion', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre el las suscripciones de MCTuristic' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Suscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del tipo de servicio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoServicio', @level2type=N'COLUMN',@level2name=N'idTipoServ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del Servicio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoServicio', @level2type=N'COLUMN',@level2name=N'NombreServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre el Tipo de servicio del establecimiento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoServicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del tipo de sitio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSitio', @level2type=N'COLUMN',@level2name=N'idTipoSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del tipo de sitio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSitio', @level2type=N'COLUMN',@level2name=N'NombreSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion del tipo de sitio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSitio', @level2type=N'COLUMN',@level2name=N'DescripcionSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre el Tipo de Sitio ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSitio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador del tipo de Suscripcion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSuscripcion', @level2type=N'COLUMN',@level2name=N'idSuscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del tipo de Suscripcion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSuscripcion', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Monto del tipo de Suscripcion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSuscripcion', @level2type=N'COLUMN',@level2name=N'Monto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tiempo de suscripcion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSuscripcion', @level2type=N'COLUMN',@level2name=N'TiempoSuscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre el Tipo de Suscripcion de MCTuristic ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TipoSuscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'identificador unico del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'IdUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'Nombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellidos del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'Apellidos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contrasena del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'Contrasena'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telefono Celular del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'TelefonoCelular'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de nacimiento del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'FechaNacimiento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foto del usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'Foto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Información sobre los usuarios de MCTuristic ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario'
GO