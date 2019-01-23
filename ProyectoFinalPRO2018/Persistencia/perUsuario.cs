using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perUsuario
    {
        public int Baja(string pUsername)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarUsuario", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public List<Usuario> Buscar(string pUsername)
        {
            List<Usuario> lista = new List<Usuario>();

            Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("BuscarCliente", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente objCliente = new Cliente(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["direccion"].ToString(), dr["telefono"].ToString());
                lista.Add(objCliente);
            }

            Conexion.Desconectar();
            Conexion.Conectar();

            cmd = new SqlCommand("BuscarEmpleado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Empleado objEmpleado = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), (TimeSpan)(dr["horaInicio"]), (TimeSpan)(dr["horaFin"]));
                lista.Add(objEmpleado);
            }

            Conexion.Desconectar();

            return lista;
        }

        /*public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ListarClientes", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente objCliente = new Cliente(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["direccion"].ToString(), dr["telefono"].ToString());
                lista.Add(objCliente);
            }

            Conexion.Desconectar();
            Conexion.Conectar();

            cmd = new SqlCommand("ListarEmpleaados", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Empleado objEmpleado = new Empleado(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), (TimeSpan)(dr["horaInicio"]), (TimeSpan)(dr["horaFin"]));
                lista.Add(objEmpleado);
            }

            Conexion.Desconectar();

            return lista;
        }*/

        public DataTable Login(string pUsername, string pPassword)
        {
            Conexion.Conectar();

            DataTable dt = new DataTable("Login");
            SqlCommand cmd = new SqlCommand("ListarClientes", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("userName", pUsername));
            cmd.Parameters.Add(new SqlParameter("password", pPassword));

            SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);

            sqlAdp.Fill(dt);

            return dt;
        }
    }
}
