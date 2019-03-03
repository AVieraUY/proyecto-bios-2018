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
        public void Alta(Pedido pedido)
        {
            SqlConnection c = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AltaPedido", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("codMedicamento", pedido.Medicamento.Codigo));
            cmd.Parameters.Add(new SqlParameter("rut", pedido.Medicamento.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("username", pedido.Cliente.Username));
            cmd.Parameters.Add(new SqlParameter("cantidad", pedido.Cantidad));
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
                        throw new Exception("No existe el Cliente.");
                    }
                case -2:
                    {
                        throw new Exception("El Medicamento no es correcto.");
                    }
                case -3:
                    {
                        throw new Exception("La cantidad debe ser mayor a cero");
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
        public void Baja(Pedido pedido)
        {
            SqlConnection c = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("EliminarPedido", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("numero", pedido.Codigo));
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
                        throw new Exception("No existe el Pedido.");
                    }
                case -2:
                    {
                        throw new Exception("No se puede  elminar el Pedido, su estado no es generado.");
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
        public Pedido Buscar(int pCodigo)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("BuscarPedido", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("num", pCodigo));

            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perMedicamento pmed = new perMedicamento();
            perCliente pcli = new perCliente();
            perFarmaceutica pfar = new perFarmaceutica();
            
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), pcli.Buscar(dr["username"].ToString()), pCodigo, Convert.ToInt32(dr["cantidad"].ToString()), (dr["estado"].ToString()));
            }

            dr.Close();
            Conexion.Desconectar(c);

            return p;
        }
        public List<Pedido> ListarPorMedicamento(Medicamento Med, string estado)
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("PedidosporMedicamento", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("CodMEd", Med.Codigo));
            cmd.Parameters.Add(new SqlParameter("rut", Med.Farmaceutica.Ruc));
            cmd.Parameters.Add(new SqlParameter("estado", estado));

            SqlDataReader dr = cmd.ExecuteReader();

            Pedido pe = null;
            perCliente pcli = new perCliente();

            while (dr.Read())
            {
                pe = new Pedido(Med, pcli.Buscar(dr["username"].ToString()), Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), (dr["estado"].ToString()));
                lista.Add(pe);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;
        }
        public List<Pedido> ListarPorEstado(Pedido pe)
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarporEstado", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("estado", pe.Estado));
            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perCliente pcli = new perCliente();
            perMedicamento pmed = new perMedicamento();
            perFarmaceutica pfar = new perFarmaceutica();
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), pcli.Buscar(dr["username"].ToString()), Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()),(dr["estado"].ToString()));

                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;


        }
        public List<Pedido> ListarPorCliente(Cliente cli)
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("PedidosGeneradosxCliente", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("user", cli.Username));
            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perMedicamento pmed = new perMedicamento();
            perFarmaceutica pfar = new perFarmaceutica();
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), cli, Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), (dr["estado"].ToString()));

                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;


        }
        public void CambiarEstado(Pedido pPedido)
        {
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("CambiarEstado", c);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("num", pPedido.Codigo));
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
                        throw new Exception("El pedido ya fue entregado.");
                    }
                case -2:
                    {
                        throw new Exception("No se puede cambiar el estado del pedido.");
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
        public List<Pedido> ListarPedido()
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection c = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("ListarPedido", c);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            Pedido p = null;
            perCliente pcli = new perCliente();
            perMedicamento pmed = new perMedicamento();
            perFarmaceutica pfar = new perFarmaceutica();
            while (dr.Read())
            {
                p = new Pedido(pmed.Buscar(pfar.Buscar(Convert.ToInt64(dr["Rut"].ToString())), Convert.ToInt32(dr["codMedicamento"].ToString())), pcli.Buscar(dr["username"].ToString()), Convert.ToInt32(dr["numero"].ToString()), Convert.ToInt32(dr["cantidad"].ToString()), (dr["estado"].ToString()));

                lista.Add(p);
            }

            dr.Close();
            Conexion.Desconectar(c);

            return lista;


        }



    }
}
