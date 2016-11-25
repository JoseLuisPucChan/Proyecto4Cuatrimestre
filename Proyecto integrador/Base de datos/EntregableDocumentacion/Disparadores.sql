------------------Verficar si existe el Administrador
CREATE TRIGGER InsertaAdmin ON Administrador  
AFTER INSERT  
AS  
IF EXISTS (SELECT *  
           FROM Administrador AS p   
           JOIN inserted AS i   
           ON p.Email = i.Email
          )  
BEGIN  
RAISERROR ('Un Administrador ya ha se registrado con el email ingresado', 16, 1);  
ROLLBACK TRANSACTION;  
RETURN   
END;  
GO
------------------Verficar si existe el Usuario
CREATE TRIGGER InsertUser ON Usuario  
AFTER INSERT  
AS  
IF EXISTS (SELECT *  
           FROM Usuario AS p   
           JOIN inserted AS i   
           ON p.Email = i.Email
          )  
BEGIN  
RAISERROR ('Un Usuario ya ha se registrado con el email ingresado', 16, 1);  
ROLLBACK TRANSACTION;  
RETURN   
END;  
GO
------------Protege la tabla Administradores para que no sea eliminada
   CREATE TRIGGER TR_Seguridad
       ON DATABASE FOR Administrador , Usuario
       AS
       BEGIN
         RAISERROR ('No está permitido borrar ni modificar tablas !' , 16, 1)
         ROLLBACK TRANSACTION

       END
GO