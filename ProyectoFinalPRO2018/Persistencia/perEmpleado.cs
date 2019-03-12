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
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AgregarEmpleado", c);
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
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarEmpleado", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

           Empleado emp = null;

            while(dr.Read())
            {
                string hi = dr["horaInicio"].ToString().Remove(3);
                emp = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["horaInicio"].ToString().Remove(5) ,(dr["horaFin"].ToString().Remove(5)));
            }

            dr.Close();
            Conexion.Desconectar(c);

            return emp;
        }

        public void Modificacion(Empleado pEmpleado)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarEmpleado", c);
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

        public Empleado Login(string pUsername, string pPassword)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("LoginEmpleado", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("username", pUsername));
            cmd.Parameters.Add(new SqlParameter("password", pPassword));

            SqlDataReader dr = cmd.ExecuteReader();

            Empleado e = null;

            while(dr.Read())
            {
                e = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["horaInicio"].ToString().Remove(5), dr["horaFin"].ToString().Remove(5));
            }

            Conexion.Desconectar(c);

            return e;
        }
        public void Baja(Empleado emp)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarUsuario", c);
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
