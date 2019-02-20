using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negFarmaceutica
    {
        public static void Alta(Farmaceutica pFarmaceutica)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Alta(pFarmaceutica);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("Ya existe la farmacéutica.");
                    }
                case  1:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }

        public static void Baja(long pRuc)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Baja(pRuc);

            switch(r)
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

        public static Farmaceutica Buscar(long pRuc)
        {
           //perFarmaceutica pf = new perFarmaceutica();


           // Farmaceutica f = pf.Buscar(pRuc);
            Farmaceutica f = perFarmaceutica.Buscar(pRuc);

            //if (f == null)
            //    throw new Exception("No existe la farmacéutica.");

            return f;
        }

        public static void Modificacion(Farmaceutica pFarmaceutica)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Modificacion(pFarmaceutica);

            switch(r)
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
            perFarmaceutica pf = new perFarmaceutica();

            return pf.Listar();
        }
    }
}
