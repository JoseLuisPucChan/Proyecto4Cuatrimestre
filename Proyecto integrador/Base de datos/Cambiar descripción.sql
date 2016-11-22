use DiccionarioDatos
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n del alumno' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Alumno'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo �nico del administrador' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Administrador',
@level2type='COLUMN',
@level2name='IdAdministrador'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre del alumno' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Alumno',
@level2type='COLUMN',
@level2name='NombreAlumno'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Apellido del alumno' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Alumno',
@level2type='COLUMN',
@level2name='ApellidoAlumno'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Cuenta del alumno' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Alumno',
@level2type='COLUMN',
@level2name='CuentaAlumno'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Contrase�a del alumno' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Alumno',
@level2type='COLUMN',
@level2name='ContrasenaAlumno'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor',
@level2type='COLUMN',
@level2name='IdProfesor'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor',
@level2type='COLUMN',
@level2name='NombreProfesor'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Apellido del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor',
@level2type='COLUMN',
@level2name='ApellidoProfesor'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Cuenta del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor',
@level2type='COLUMN',
@level2name='CuentaProfesor'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Contrase�a del profesor' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Profesor',
@level2type='COLUMN',
@level2name='ContrasenaProfesor'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la bibliograf�a' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Bibliografia'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la bibliograf�a' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Bibliografia',
@level2type='COLUMN',
@level2name='IdBibliografia'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Texto de la bibliograf�a' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Bibliografia',
@level2type='COLUMN',
@level2name='TextoBibliografia'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Llave for�nea de la tabla Materia en bibliograf�a' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Bibliografia',
@level2type='COLUMN',
@level2name='IdMateriaBiblio'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n del buz�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Buzon'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del buz�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Buzon',
@level2type='COLUMN',
@level2name='IdBuzon'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Mensaje del buz�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Buzon',
@level2type='COLUMN',
@level2name='MensajeBuzon'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en el buz�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Buzon',
@level2type='COLUMN',
@level2name='IdProfesorBuzon'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la carrera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Carrera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la carrera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Carrera',
@level2type='COLUMN',
@level2name='IdCarrera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre de la carrera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Carrera',
@level2type='COLUMN',
@level2name='NombreCarrera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en la carrera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Carrera',
@level2type='COLUMN',
@level2name='IdProfesorCarrera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la escuela en la carrera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Carrera',
@level2type='COLUMN',
@level2name='IdEscuelaCarrera'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la cartelera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Cartelera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la cartelera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Cartelera',
@level2type='COLUMN',
@level2name='IdCartelera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre de la cartelera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Cartelera',
@level2type='COLUMN',
@level2name='NombreCartelera'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en la cartelera' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Cartelera',
@level2type='COLUMN',
@level2name='IdProfesorCartelera'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la escuela' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Escuela'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la escuela' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Escuela',
@level2type='COLUMN',
@level2name='IdEscuela'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre de la escuela' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Escuela',
@level2type='COLUMN',
@level2name='NombreEscuela'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Direcci�n de la escuela' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Escuela',
@level2type='COLUMN',
@level2name='DireccionEscuela'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en la escuela' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Escuela',
@level2type='COLUMN',
@level2name='IdProfesorEscuela'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='IdEvaluacion'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre de la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='NombreEvaluacion'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Cantidad de la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='CantidadEvaluacion'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nota de la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='NotaEvaluacion'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='IdProfesorEva'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del alumno en la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='IdAlumnoEva'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la materia en la evaluaci�n' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Evaluacion',
@level2type='COLUMN',
@level2name='IdMateriaEva'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n de la materia' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Materia'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la materia' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Materia',
@level2type='COLUMN',
@level2name='IdMateria'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre de la materia' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Materia',
@level2type='COLUMN',
@level2name='NombreMateria'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la carrera en la materia' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Materia',
@level2type='COLUMN',
@level2name='IdCarreraMateria'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en la materia' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Materia',
@level2type='COLUMN',
@level2name='IdProfesorMateria'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n del periodo' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Periodo'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del periodo' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Periodo',
@level2type='COLUMN',
@level2name='IdPeriodo'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre del periodo' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Periodo',
@level2type='COLUMN',
@level2name='NombrePeriodo'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo de la carrera en el periodo' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Periodo',
@level2type='COLUMN',
@level2name='IdCarreraPeriodo'
GO

EXEC sys.sp_addextendedproperty
@name='MS_Description',
@value='Informaci�n del tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro',
@level2type='COLUMN',
@level2name='IdTema'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Nombre del tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro',
@level2type='COLUMN',
@level2name='NombreTema'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='Categor�a del tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro',
@level2type='COLUMN',
@level2name='CategoriaTema'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del profesor en el tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro',
@level2type='COLUMN',
@level2name='IdProfesorTema'
GO

EXEC sp_addextendedproperty
@name='MS_Description',
@value='C�digo del alumno en el tema del foro' ,
@level0type='SCHEMA',
@level0name='dbo',
@level1type='TABLE',
@level1name='Tema_Foro',
@level2type='COLUMN',
@level2name='IdAlumnoTema'
GO