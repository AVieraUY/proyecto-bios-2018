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
        public void Alta(Medicamento pMedicamento)
        {
            perMedicamento pm = new perMedicamento();

            int r = pm.Alta(pMedicamento);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("Ya existe el medicamento.");
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

        public void Baja(int pRuc, int pCodigo)
        {
            perMedicamento pm = new perMedicamento();

            int r = pm.Baja(pRuc, pCodigo);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el medicamento.");
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

        public Medicamento Buscar(int pRuc, int pCodigo)
        {
            perMedicamento pm = new perMedicamento();

            Medicamento m = pm.Buscar(pRuc, pCodigo);

            if (m.Equals(null))
                throw new Exception("No existe el medicamento.");

            return m;
        }

        public void Modificacion(Medicamento pMedicamento)
        {
            perMedicamento pm = new perMedicamento();

            int r = pm.Modificacion(pMedicamento);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el medicamento.");
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

        public List<Medicamento> Listar()
        {
            perMedicamento pm = new perMedicamento();

            return pm.Listar();
        }

        public List<Medicamento> ListarPorFarmaceutica(int pRuc)
        {
            perMedicamento pm = new perMedicamento();

            return pm.ListarPorFarmaceutica(pRuc);
        }
    }
}
