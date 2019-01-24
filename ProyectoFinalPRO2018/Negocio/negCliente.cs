using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negCliente
    {
        public void Alta(Cliente pCliente)
        {
            perCliente pc = new perCliente();

            int r = pc.Alta(pCliente);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("Ya existe el cliente.");
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

        public Cliente Buscar(string pUsername)
        {
            perCliente pc = new perCliente();

            Cliente c = pc.Buscar(pUsername);

            if(c.Equals(null))
                throw new Exception("No existe el cliente.");

            return c;
        }

        public void Modificacion(Cliente pCliente)
        {
            perCliente pc = new perCliente();

            int r = pc.Modificacion(pCliente);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el cliente.");
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
