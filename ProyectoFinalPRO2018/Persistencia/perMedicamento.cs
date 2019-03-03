using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perMedicamento
    {
        public void Alta(Medicamento pMedicamento)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AltaMedicamento", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pMedicamento.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pMedicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("nombre", pMedicamento.Nombre));
            cmd.Parameters.Add(new SqlParameter("descipcion", pMedicamento.Descripcion));
            cmd.Parameters.Add(new SqlParameter("precio", pMedicamento.Precio));

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
                        throw new Exception("Ya existe el medicamento.");
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

        public void Baja(Medicamento pMedicamento)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarMedicamento", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pMedicamento.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pMedicamento.Codigo));

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
                        throw new Exception("No existe el medicamento.");
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

        public Medicamento Buscar(Farmaceutica pFarmaceutica, int pCodigo)
        {
           SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarMedicamento", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pFarmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pCodigo));

            SqlDataReader dr = cmd.ExecuteReader();

            Medicamento m = null;

            while(dr.Read())
            {
                m = new Medicamento(pFarmaceutica, Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descipcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
            }

            dr.Close(); 
            Conexion.Desconectar(c);

            return m;
        }

        public void Modificacion(Medicamento pMedicamento)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarMedicamento", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pMedicamento.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pMedicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("nombre", pMedicamento.Nombre));
            cmd.Parameters.Add(new SqlParameter("descipcion", pMedicamento.Descripcion));
            cmd.Parameters.Add(new SqlParameter("precio", pMedicamento.Precio));

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
                        throw new Exception("No existe el medicamento.");
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

        public List<Medicamento> Listar()
        {
            List<Medicamento> lista = new List<Medicamento>();

            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarMedicamentos", c);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            perFarmaceutica perf = new perFarmaceutica();

            while(dr.Read())
            {
                Medicamento m = new Medicamento(perf.Buscar(Convert.ToInt64(dr["rut"].ToString())), Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descipcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
                lista.Add(m);
            }

            dr.Close();
            Conexion.Desconectar(c);
       
            return lista;
        }

        public List<Medicamento> ListarPorFarmaceutica(Farmaceutica pFarmaceutica)
        {
            List<Medicamento> lista = new List<Medicamento>();

            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("MedicamentosxFarmaceutica", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pFarmaceutica.Ruc));

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Medicamento m = new Medicamento(pFarmaceutica, Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descipcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
                lista.Add(m);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;
        }
    }
}
