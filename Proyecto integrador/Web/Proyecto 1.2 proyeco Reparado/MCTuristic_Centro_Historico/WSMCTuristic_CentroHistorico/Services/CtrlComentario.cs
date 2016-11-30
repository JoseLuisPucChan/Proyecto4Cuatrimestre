using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlComentario
    {
        DAO.ComentariosDAO oComentarios;
        public int InsertarComentarios(object obj)
        {
            oComentarios = new DAO.ComentariosDAO();
            return oComentarios.AgregarComentarios(obj);
        }

        public int ModificarComentarios(object obj)
        {
            oComentarios = new DAO.ComentariosDAO();
            return oComentarios.ActualizarComentarios(obj);
        }

        public int EliminarComentarios(object obj)
        {
            oComentarios = new DAO.ComentariosDAO();
            return oComentarios.EliminarComentarios(obj);
        }
        public DataSet topComentariosDS()
        {
            oComentarios = new DAO.ComentariosDAO();
            return oComentarios.ComentariosDS();
        }
        
    }
}