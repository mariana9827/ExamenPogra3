﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PuntosExtra.CapaConexion
{
    public class Controladora
    {
        private SqlConnection oCN = new SqlConnection("Server = tcp:clases.database.windows.net, 1433; Initial Catalog = Ejemplo; Persist Security Info = False; User ID = estudiante; Password =progra3.; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        public bool abrirConexion ()
        {
            try
            {
                oCN.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool cerrarConexion ()
        {
            try
            {
                if (oCN.State == ConnectionState.Open)
                {
                    oCN.Close();
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                oCN.Close();
                return true;
            }
        }

        public bool ejecutar (SqlCommand oSQLC) //Inserts,Updates,Delet
        {
            try
            {
                oSQLC.Connection = oCN;
                if (abrirConexion())
                {
                    oSQLC.ExecuteNonQuery();
                }
                cerrarConexion();
                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable ejecutarSelect (SqlCommand oSQLC)
        {
            try
            {
                oSQLC.Connection = oCN;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLAD = new SqlDataAdapter(oSQLC);
                if (abrirConexion())
                {
                    oSQLAD.Fill(oDT);
                }
                cerrarConexion();
                return oDT;


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}