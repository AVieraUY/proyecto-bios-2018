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
        public void Alta(Farmaceutica pFarmaceutica)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Alta(pFarmaceutica);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("Ya existe la farmacéutica.");
                    }
                case 0:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }

        public void Baja(int pRuc)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Baja(pRuc);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe la farmacéutica.");
                    }
                case 0:
                    {
                        break;
                    }
                default:
                    {
                        throw new Exception("Error desconocido.");
                    }
            }
        }

        public Farmaceutica Buscar(int pRuc)
        {
            perFarmaceutica pf = new perFarmaceutica();

            Farmaceutica f = pf.Buscar(pRuc);

            if (f.Equals(null))
                throw new Exception("No existe la farmacéutica.");

            return f;
        }

        public void Modificacion(Farmaceutica pFarmaceutica)
        {
            perFarmaceutica pf = new perFarmaceutica();

            int r = pf.Modificacion(pFarmaceutica);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe la farmacéutica.");
                    }
                case 0:
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
