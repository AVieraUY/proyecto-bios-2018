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
        public int Alta(Medicamento pMedicamento)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("AltaMedicamento", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pMedicamento.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pMedicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("nombre", pMedicamento.Nombre));
            cmd.Parameters.Add(new SqlParameter("descipcion", pMedicamento.Descripcion));
            cmd.Parameters.Add(new SqlParameter("precio", pMedicamento.Precio));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public int Baja(int pRuc, int pCodigo)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarMedicamento", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));
            cmd.Parameters.Add(new SqlParameter("codigo", pCodigo));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public Medicamento Buscar(int pRuc, int pCodigo)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarMedicamento", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));
            cmd.Parameters.Add(new SqlParameter("codigo", pCodigo));

            SqlDataReader dr = cmd.ExecuteReader();

            Medicamento m = null;

            while(dr.Read())
            {
                m = new Medicamento(Convert.ToInt32(dr["rut"].ToString()), Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descipcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
            }

            Conexion.Desconectar();

            return m;
        }

        public int Modificacion(Medicamento pMedicamento)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ModificarMedicamento", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pMedicamento.Ruc));
            cmd.Parameters.Add(new SqlParameter("codigo", pMedicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("nombre", pMedicamento.Nombre));
            cmd.Parameters.Add(new SqlParameter("descipcion", pMedicamento.Descripcion));
            cmd.Parameters.Add(new SqlParameter("precio", pMedicamento.Precio));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }

        public List<Medicamento> Listar()
        {
            List<Medicamento> lista = new List<Medicamento>();

            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarMedicamentos", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Medicamento m = new Medicamento(Convert.ToInt32(dr["rut"].ToString()), Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descripcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
                lista.Add(m);
            }

            Conexion.Desconectar();

            return lista;
        }

        public List<Medicamento> ListarPorFarmaceutica(int pRuc)
        {
            List<Medicamento> lista = new List<Medicamento>();

            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("MedicamentosxFarmaceutica", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("rut", pRuc));

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Medicamento m = new Medicamento(Convert.ToInt32(dr["rut"].ToString()), Convert.ToInt32(dr["codigo"].ToString()), dr["nombre"].ToString(), dr["descripcion"].ToString(), Convert.ToDecimal(dr["precio"].ToString()));
                lista.Add(m);
            }

            Conexion.Desconectar();

            return lista;
        }
    }
}
