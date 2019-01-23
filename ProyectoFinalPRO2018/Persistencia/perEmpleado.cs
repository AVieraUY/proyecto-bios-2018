using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perEmpleado
    {
        public int Alta(Empleado pEmpleado)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AgregarEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pEmpleado.Username));
            cmd.Parameters.Add(new SqlParameter("pass", pEmpleado.Password));
            cmd.Parameters.Add(new SqlParameter("nombre", pEmpleado.Nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", pEmpleado.Apellido));
            cmd.Parameters.Add(new SqlParameter("horaInicio", pEmpleado.HoraInicio));
            cmd.Parameters.Add(new SqlParameter("horaFin", pEmpleado.HoraFin));
            cmd.Parameters.Add(new SqlParameter("tipo", 2));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public Empleado Buscar(string pUsername)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

            Empleado e = null;

            while(dr.Read())
            {
                e = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), (TimeSpan)(dr["horaInicio"]), (TimeSpan)(dr["horaFin"]));
            }

            Conexion.Desconectar();

            return e;
        }

        public int Modificacion(Empleado pEmpleado)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pEmpleado.Username));
            cmd.Parameters.Add(new SqlParameter("pass", pEmpleado.Password));
            cmd.Parameters.Add(new SqlParameter("nombre", pEmpleado.Nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", pEmpleado.Apellido));
            cmd.Parameters.Add(new SqlParameter("horaInicio", pEmpleado.HoraInicio));
            cmd.Parameters.Add(new SqlParameter("horaFin", pEmpleado.HoraFin));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }
    }
}
