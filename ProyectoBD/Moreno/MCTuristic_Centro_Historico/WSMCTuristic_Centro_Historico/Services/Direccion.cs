using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_Centro_Historico.Services
{
    public class Direccion
    {
        DAO.Direccion oDireccion;

        public int InsertarDireccion(object obj)
        {
            oDireccion = new DAO.Direccion();
            return oDireccion.AgregarDireccion(obj);
        }

        public int ModificarDireccion(object obj)
        {
            oDireccion = new DAO.Direccion();
            return oDireccion.ActualizarDireccion(obj);
        }

        public int EliminarDireccion(object obj)
        {
            oDireccion = new DAO.Direccion();
            return oDireccion.EliminarDireccion(obj);
        }

    }
}