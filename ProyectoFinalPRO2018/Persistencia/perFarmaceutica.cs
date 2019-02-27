using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perFarmaceutica
    {
        public void Alta(Farmaceutica pFarmaceutica)
        {
            Conexion c = Conexion.Conectar();

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

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value);

            switch (a)
            {
                case -1:
                    {
                        throw new Exception("Ya existe la farmacéutica.");
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

        public void Baja(Farmaceutica f)
        {
            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", f.Ruc));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value.ToString());

            switch (a)
            {
                case -1:
                    {
                        throw new Exception("No existe la farmacéutica.");
                    }
                case -2:
                    {
                        throw new Exception("No es posible eliminar ya que tiene pedidos asociados.");
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

        public Farmaceutica Buscar(long pRuc)
        {
            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));
            
            SqlDataReader dr = cmd.ExecuteReader();

            Farmaceutica f = null;

            while(dr.Read())
            {
                f = new Farmaceutica(pRuc, dr["nombre"].ToString(), dr["mail"].ToString(), dr["direccion"].ToString());
            }

            dr.Close();
            Conexion.Desconectar(c);

            return f;
        }

        public void Modificacion(Farmaceutica pFarmaceutica)
        {
            Conexion c = Conexion.Conectar();

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

            Conexion.Desconectar(c);

            int a = Convert.ToInt32(r.Value);

            switch (a)
            {
                case -1:
                    {
                        throw new Exception("No existe la farmacéutica.");
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

        public List<Farmaceutica> Listar()
        {
            List<Farmaceutica> lista = new List<Farmaceutica>();

            Conexion c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarFarmaceuticas", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Farmaceutica objFarmaceutica = new Farmaceutica(Convert.ToInt64(dr["rut"].ToString()), dr["nombre"].ToString(), dr["mail"].ToString(), dr["direccion"].ToString());
                lista.Add(objFarmaceutica);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;
        }
    }
}
