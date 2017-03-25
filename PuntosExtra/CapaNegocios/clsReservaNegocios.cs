using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PuntosExtra.CapaNegocios
{
    public class clsReservaNegocios
    {
        public bool InsertarReserv (String strNombre, String strCedula, String strFecha, String strTipo)
        {
            return new CapaConexion.clsReservaControladora().insertarReserva(new CapaEntidad.clsReservaEntidad(strNombre, strCedula, strFecha, strTipo));
        }

        public DataTable SelectReserv ()
        {
            return new CapaConexion.clsReservaControladora().buscarRerva();
        }

        public DataTable BuscarReserv ()
        {
            return new CapaConexion.clsReservaControladora().verReservas();
        }

    }
}