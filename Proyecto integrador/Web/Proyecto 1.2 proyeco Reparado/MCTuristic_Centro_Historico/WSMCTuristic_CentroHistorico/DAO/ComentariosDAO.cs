using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WSMCTuristic_CentroHistorico.DAO
{
    public class ComentariosDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.ComentariosBO oComentarios;
        public int AgregarComentarios(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oComentarios = (BO.ComentariosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_comentarios";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oComentarios.Nombre;
            cmd.Parameters.Add("@Contenido", SqlDbType.VarChar).Value = oComentarios.Contenido;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = oComentarios.Status;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.VarChar).Value = oComentarios.IdUsuario;



            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

        public int ActualizarComentarios(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oComentarios = (BO.ComentariosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_comentarios";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdComentario ", SqlDbType.Int).Value = oComentarios.IdComentario;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oComentarios.Nombre;
            cmd.Parameters.Add("@Contenido", SqlDbType.VarChar).Value = oComentarios.Contenido;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = oComentarios.Status;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.VarChar).Value = oComentarios.IdUsuario;


            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

        public int EliminarComentarios(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oComentarios = (BO.ComentariosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_comentario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdComentario ", SqlDbType.Int).Value = oComentarios.IdComentario;

            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }
        // Agregue el dataset de esta tabla. Diosemir Nah
        public DataSet ComentariosDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC primero12registros";
            return conn.TablaDS(sql);
        }
    }
}