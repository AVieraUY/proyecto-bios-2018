using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perPedido
    {
        public int Alta(Pedido pedido)
        {
            Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AltaPedido", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("codMedicamento", pedido.Medicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("rut", pedido.Medicamento.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("username", pedido.Cliente.Username));
            cmd.Parameters.Add(new SqlParameter("cantidad", pedido.Cantidad));
            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);

        }
        public int Baja(Pedido pedido)
        {
            SqlCommand cmd = new SqlCommand("EliminarPedido", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("numero", pedido.Codigo));
            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }
        public Pedido Buscar(int pCodigo)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarPedido", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("numero", pCodigo));

            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perMedicamento pmed = null;
            perCliente pcli = null;
            perFarmaceutica pfar = null;
            
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), pcli.Buscar(dr["username"].ToString()), pCodigo, Convert.ToInt32(dr["cantidad"].ToString()), Convert.ToByte(dr["estado"].ToString()));
            }

            dr.Close();
            Conexion.Desconectar();

            return p;
        }
        public List<Pedido> ListarPorMedicamento(Medicamento Med)
        {
            List<Pedido> lista = new List<Pedido>();
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarPedidosxMedicamento", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("CodMEd", Med.Codigo));
            cmd.Parameters.Add(new SqlParameter("rut", Med.Farmaceutica.Ruc));

            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perCliente pcli = null;

            while (dr.Read())
            {
                p = new Pedido(Med, pcli.Buscar(dr["username"].ToString()), Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), Convert.ToByte(dr["estado"].ToString()));
                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar();

            return lista;
        }
        public List<Pedido> ListarPorEstado(byte pEstado)
        {
            List<Pedido> lista = new List<Pedido>();
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarPedido", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("estado", pEstado));
            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perCliente pcli = null;
            perMedicamento pmed = null;
            perFarmaceutica pfar = null;
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), pcli.Buscar(dr["username"].ToString()), Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), pEstado);

                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar();

            return lista;


        }
        public List<Pedido> ListarPorCliente(Cliente cli)
        {
            List<Pedido> lista = new List<Pedido>();
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("PedidosGeneradosxCliente", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("user", cli.Username));
            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perMedicamento pmed = null;
            perFarmaceutica pfar = null;
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), cli, Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), Convert.ToByte(dr["estado"].ToString()));

                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar();

            return lista;


        }
        public int CambiarEstado(Pedido p)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("CambiarEstado", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("numero", p.Codigo));
            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }



    }
}
