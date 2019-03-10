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
            pf.Alta(pFarmaceutica);
        }

        public static void Baja(Farmaceutica f)
        {
            perFarmaceutica pf = new perFarmaceutica();
            pf.Baja(f);  
        }

        public static Farmaceutica Buscar(long pRuc)
        {
           perFarmaceutica pf = new perFarmaceutica();

            Farmaceutica f = pf.Buscar(pRuc);
            return f;
        }

        public static void Modificacion(Farmaceutica pFarmaceutica)
        {
            perFarmaceutica pf = new perFarmaceutica();
            pf.Modificacion(pFarmaceutica);

        }

        public static List<Farmaceutica> Listar()
        {
            perFarmaceutica pf = new perFarmaceutica();

            return pf.Listar();
        }
    }
}
