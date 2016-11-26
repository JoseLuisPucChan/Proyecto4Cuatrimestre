---------------Indices-------------------
------Este indice nos sirve para tener una busqueda mas clara con respecto a los eventos registrados
create  index NombreEventos
on Eventos(NombreEvent)
------ Este indice es para realizar una busqueda adecuada a nuestra tabla usuario
create index NombreUsuario
on Usuario(Nombre ,Apellidos)
------ Este indice realiza una busqueda mas sencilla sobre los servicios que ofrece nuestra empresa.

create index servicios
on Servicios(NombreServ,OfertaServicio)

------ Este Indice nos ayuda a realizar una busqueda  de los establecimientos 
create index sp_establecimientos
on Establecimiento(NomEstable,Telefono)


