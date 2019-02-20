using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perFarmaceutica
    {
        public int Alta(Farmaceutica pFarmaceutica)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AltaFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pFarmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("nombre", pFarmaceutica.Nombre));
            cmd.Parameters.Add(new SqlParameter("direccion", pFarmaceutica.Direccion));
            cmd.Parameters.Add(new SqlParameter("mail", pFarmaceutica.Correo));

            SqlParameter r = new SqlParameter();
            r.Direction = System.Data.ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public int Baja(long pRuc)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value.ToString());
        }

        public static Farmaceutica Buscar(long pRuc)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));
            
            SqlDataReader dr = cmd.ExecuteReader();

            Farmaceutica f = null;

            while(dr.Read())
            {

                string n = dr["nombre"].ToString();
                string m = dr["mail"].ToString();
                string d = dr["direccion"].ToString();

                f = new Farmaceutica(pRuc, dr["nombre"].ToString(), dr["mail"].ToString(), dr["direccion"].ToString());
            }

            dr.Close();
            Conexion.Desconectar();

            return f;
        }

        public int Modificacion(Farmaceutica pFarmaceutica)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pFarmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("nombre", pFarmaceutica.Nombre));
            cmd.Parameters.Add(new SqlParameter("direccion", pFarmaceutica.Direccion));
            cmd.Parameters.Add(new SqlParameter("mail", pFarmaceutica.Correo));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public List<Farmaceutica> Listar()
        {
            List<Farmaceutica> lista = new List<Farmaceutica>();

            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarFarmaceuticas", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Farmaceutica objFarmaceutica = new Farmaceutica(Convert.ToInt64(dr["rut"].ToString()), dr["nombre"].ToString(), dr["mail"].ToString(), dr["direccion"].ToString());
                lista.Add(objFarmaceutica);
            }

            dr.Close();
            Conexion.Desconectar();

            return lista;
        }
    }
}
