using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PuntosExtra.CapaConexion
{
    public class clsReservaControladora
    {
        public bool insertarReserva(CapaEntidad.clsReservaEntidad Reserva)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) VALUES (@Tipo_Reserva, @Fecha, @Cliente, @Cedula)";
            command.CommandText = "Insert into dbo.Reserva Values(@tipo_reserva,@fecha_reserva,@nombre_cliente,@cedula_cliente)";
            command.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, 30).Value = Reserva.propStrNombre;
            command.Parameters.Add("@tipo_reserva", SqlDbType.VarChar, 10).Value = Reserva.propStrTipo;
            command.Parameters.Add("@fecha_reserva", SqlDbType.VarChar, 10).Value = Reserva.propStrFecha;
            command.Parameters.Add("@cedula_cliente", SqlDbType.VarChar, 30).Value = Reserva.propStrCedula;

            return new Controladora().ejecutar(command);
        }

        public DataTable buscarRerva ()
        {
             SqlCommand command = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva WHERE num_reserva = 1");
             return new Controladora().ejecutarSelect(command);
        }


        public DataTable verReservas ()
        {
            SqlCommand command = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva");
            return new Controladora().ejecutarSelect(command);
        }
    }
}