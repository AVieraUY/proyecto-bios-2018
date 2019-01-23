using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perCliente
    {
        public int Alta(Cliente pCliente)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AgregarCliente", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pCliente.Username));
            cmd.Parameters.Add(new SqlParameter("pass", pCliente.Password));
            cmd.Parameters.Add(new SqlParameter("nombre", pCliente.Nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", pCliente.Apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", pCliente.DireccionEntrega));
            cmd.Parameters.Add(new SqlParameter("telefono", pCliente.Telefono));
            cmd.Parameters.Add(new SqlParameter("tipo", 1));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public Cliente Buscar(string pUsername)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarCliente", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlDataReader dr = cmd.ExecuteReader();

            Cliente c = null;

            while(dr.Read())
            {
                c = new Cliente(dr["userName"].ToString(), dr["pass"].ToString(), dr["nombre"].ToString(), dr["apellido"].ToString(), dr["direccion"].ToString(), dr["telefono"].ToString());
            }

            Conexion.Desconectar();

            return c;
        }

        public int Modificacion(Cliente pCliente)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarCliente", Conexion.cnn);
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

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }
    }
}
