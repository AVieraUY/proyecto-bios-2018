using System;
using System.Data;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negUsuario
    {
        public void Baja(string pUsername)
        {
            perUsuario pu = new perUsuario();

            int r = pu.Baja(pUsername);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el usuario.");
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

        public Usuario Buscar(string pUsername)
        {
            Usuario u = null;

            negCliente nc = new negCliente();

            u = nc.Buscar(pUsername);

            if(u.Equals(null))
            {
                negEmpleado ne = new negEmpleado();

                u = ne.Buscar(pUsername);

                if (u.Equals(null))
                    throw new Exception("No existe el usuario.");
            }

            return u;
        }

        public DataTable Login(string pUsername, string pPassword)
        {
            perUsuario pu = new perUsuario();
            return pu.Login(pUsername, pPassword);
        }
    }
}
