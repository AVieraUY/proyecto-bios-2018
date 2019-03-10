using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negPedido
    {
        public static void Alta(Pedido pPedido)
        {
            perPedido pp = new perPedido();
            pp.Alta(pPedido);

        }
        public static void Baja(Pedido pPedido)
        {
            perPedido pp = new perPedido();
            pp.Baja(pPedido);
        }

        public static Pedido Buscar(int pCodigo)
        {
            perPedido pp = new perPedido();

            Pedido p = pp.Buscar(pCodigo);


            return p;
        }

        public static List<Pedido> ListarPorMedicamento(Medicamento med, string estado)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorMedicamento(med, estado);
        }

        public static List<Pedido> ListarPorEstado(Pedido p)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorEstado(p);
        }
        public static List<Pedido> ListarPorCliente(Cliente cli)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorCliente(cli);
        }
        public static void CambiarEstado(Pedido pPedido)
        {
            perPedido pp = new perPedido();
            pp.CambiarEstado(pPedido);
            
        }
        public static List<Pedido> ListarPedido()
        {
            perPedido pp = new perPedido();

            return pp.ListarPedido();
        }

    }
}
