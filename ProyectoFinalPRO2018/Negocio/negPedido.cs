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

            int r = pp.Alta(pPedido);

            switch (r)
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
        public static void Baja(Pedido pPedido)
        {
            perPedido pp = new perPedido();

            int r = pp.Baja(pPedido);

            switch (r)
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

        public static Pedido Buscar(int pCodigo)
        {
            perPedido pp = new perPedido();

            Pedido p = pp.Buscar(pCodigo);


            return p;
        }

        public static List<Pedido> ListarPorMedicamento(Medicamento med)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorMedicamento(med);
        }

        public static List<Pedido> ListarPorEstado(byte Estado)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorEstado(Estado);
        }
        public static List<Pedido> ListarPorCliente(Cliente cli)
        {
            perPedido pp = new perPedido();

            return pp.ListarPorCliente(cli);
        }
        public static void CambiarEstado(Pedido pPedido)
        {
            perPedido pp = new perPedido();

            int r = pp.CambiarEstado(pPedido);

            switch (r)
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
    }
}
