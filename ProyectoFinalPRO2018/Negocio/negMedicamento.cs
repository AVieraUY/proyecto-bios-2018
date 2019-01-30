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

        public void Baja(Farmaceutica pFarmaceutica, int pCodigo)
        {
            perMedicamento pm = new perMedicamento();

            int r = pm.Baja(pFarmaceutica, pCodigo);

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

        public Medicamento Buscar(Farmaceutica pFarmaceutica, int pCodigo)
        {
            perMedicamento pm = new perMedicamento();

            Medicamento m = pm.Buscar(pFarmaceutica, pCodigo);

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

        public List<Medicamento> ListarPorFarmaceutica(Farmaceutica pFarmaceutica)
        {
            perMedicamento pm = new perMedicamento();

            return pm.ListarPorFarmaceutica(pFarmaceutica);
        }
    }
}
