using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negMedicamento
    {
        public static void Alta(Medicamento pMedicamento)
        {
            perMedicamento pm = new perMedicamento();
            pm.Alta(pMedicamento);

        }

        public static void Baja(Medicamento pMedicamento)
        {
            perMedicamento pm = new perMedicamento();
            pm.Baja(pMedicamento);
        }

        public static Medicamento Buscar(Farmaceutica pFarmaceutica, int pCodigo)
        {
            perMedicamento pm = new perMedicamento();

            Medicamento m = pm.Buscar(pFarmaceutica, pCodigo);

            return m;
        }

        public static void Modificacion(Medicamento pMedicamento)
        {
            perMedicamento pm = new perMedicamento();
            pm.Modificacion(pMedicamento);
        }

        public static List<Medicamento> Listar()
        {
            perMedicamento pm = new perMedicamento();

            return pm.Listar();
        }

        public static List<Medicamento> ListarPorFarmaceutica(Farmaceutica pFarmaceutica)
        {
            perMedicamento pm = new perMedicamento();

            return pm.ListarPorFarmaceutica(pFarmaceutica);
        }
    }
}
