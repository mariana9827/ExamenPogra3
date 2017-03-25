using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PuntosExtra.CapaEntidad
{
    public class clsReservaEntidad
    {
        private String strNombre;
        private String strCedula;
        private String strFecha;
        private String strTipo;

        public clsReservaEntidad () { }

        public clsReservaEntidad (String strNombre, String strCedula, String strFecha, String strTipo)
        {
            this.strNombre = strNombre;
            this.strCedula = strCedula;
            this.strFecha = strFecha;
            this.strTipo = strTipo;
        }
        public String propStrNombre { get { return this.strNombre; } set { this.strNombre = value; } }
        public String propStrFecha { get { return this.strCedula; } set { this.strCedula = value; } }
        public String propStrCedula { get { return this.strFecha; } set { this.strFecha = value; } }
        public String propStrTipo { get { return this.strTipo; } set { this.strTipo = value; } }
    }

}