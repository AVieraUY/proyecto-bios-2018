using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perEmpleado
    {
        public void Alta(Empleado pEmpleado)
        {
            Conexion c = Conexion.Conectar();

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

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value);
            switch (a)
            {
                case -1:
                    {
                        throw new Exception("Ya existe el empleado.");
                    }
                case 1:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }

        public Empleado Buscar(string pUsername)
        {
            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

           Empleado emp = null;

            while(dr.Read())
            {
                emp = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["horaInicio"].ToString(), (dr["horaFin"].ToString()));
            }

            dr.Close();
            Conexion.Desconectar(c);

            return emp;
        }

        public void Modificacion(Empleado pEmpleado)
        {
            Conexion c = Conexion.Conectar();

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

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value);
            switch (a)
            {
                case -1:
                    {
                        throw new Exception("No existe el empleado.");
                    }
                case 0:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }

        public Empleado Login(string pUsername, string pPassword)
        {
            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("LoginEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("username", pUsername));
            cmd.Parameters.Add(new SqlParameter("password", pPassword));

            SqlDataReader dr = cmd.ExecuteReader();

            Empleado e = null;

            while(dr.Read())
            {
                e = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["horaInicio"].ToString(), dr["horaFin"].ToString());
            }

            Conexion.Desconectar(c);

            return e;
        }
        public void Baja(Empleado emp)
        {
            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarUsuario", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", emp.Username));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value);

            switch (a)
            {
                case -1:
                    {
                        throw new Exception("No existe el usuario.");
                    }
                case 1:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }
    }
}
