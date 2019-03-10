using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perCliente
    {
        public void Alta(Cliente pCliente)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AgregarCliente", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pCliente.Username));
            cmd.Parameters.Add(new SqlParameter("pass", pCliente.Password));
            cmd.Parameters.Add(new SqlParameter("nombre", pCliente.Nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", pCliente.Apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", pCliente.DireccionEntrega));
            cmd.Parameters.Add(new SqlParameter("telefono", pCliente.Telefono));

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
                        throw new Exception("Ya existe el cliente.");
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

        public Cliente Buscar(string pUsername)
        {
            SqlConnection x = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarCliente", x);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

            Cliente c = null;

            while(dr.Read())
            {
                c = new Cliente(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["direccion"].ToString(), dr["telefono"].ToString());
            }
            dr.Close();
            Conexion.Desconectar(x);

            return c;
        }

       
        public Cliente Login(string pUsername, string pPassword)
        {
            SqlConnection x = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("LoginCliente", x);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("username", pUsername));
            cmd.Parameters.Add(new SqlParameter("password", pPassword));

            SqlDataReader dr = cmd.ExecuteReader();

            Cliente c = null;

            while(dr.Read())
            {
                c = new Cliente(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["direccion"].ToString(), dr["telefono"].ToString());
            }

            Conexion.Desconectar(x);

            return c;
        }
    }
}
