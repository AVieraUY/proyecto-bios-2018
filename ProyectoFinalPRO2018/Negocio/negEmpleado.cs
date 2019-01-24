using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negEmpleado
    {
        public void Alta(Empleado pEmpleado)
        {
            perEmpleado pe = new perEmpleado();

            int r = pe.Alta(pEmpleado);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("Ya existe el empleado.");
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

        public Empleado Buscar(string pUsername)
        {
            perEmpleado pe = new perEmpleado();

            Empleado e = pe.Buscar(pUsername);

            if (e.Equals(null))
                throw new Exception("No existe el empleado.");

            return e;
        }

        public void Modificacion(Empleado pEmpleado)
        {
            perEmpleado pe = new perEmpleado();

            int r = pe.Modificacion(pEmpleado);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el empleado.");
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
    }
}
