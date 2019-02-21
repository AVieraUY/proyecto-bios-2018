using System;
using System.Data;
using EntidadesCompartidas;
using Persistencia;

namespace Negocio
{
    public class negUsuario
    {
        public static void Alta(Usuario pUsuario)
        {
            if(pUsuario.GetType().Equals(typeof(Cliente)))
            {
                perCliente pc = new perCliente();

                int r = pc.Alta((Cliente)pUsuario);

                switch (r)
                {
                    case -1:
                        {
                            throw new Exception("Ya existe el cliente.");
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
            else
            {
                perEmpleado pe = new perEmpleado();

                int r = pe.Alta((Empleado)pUsuario);

                switch (r)
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
        }

        public static void Baja(string pUsername)
        {
            perUsuario pu = new perUsuario();

            int r = pu.Baja(pUsername);

            switch(r)
            {
                case -1:
                    {
                        throw new Exception("No existe el usuario.");
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

        public static Usuario Buscar(string pUsername)
        {
            Usuario u = null;

            perCliente pc = new perCliente();

            u = pc.Buscar(pUsername);

            if(u.Equals(null))
            {
                perEmpleado pe = new perEmpleado();

                u = pe.Buscar(pUsername);

                if (u.Equals(null))
                    throw new Exception("No existe el usuario.");
            }

            return u;
        }

        public static void Modificacion(Usuario pUsuario)
        {
            if (pUsuario.GetType().Equals(typeof(Cliente)))
            {
                perCliente pc = new perCliente();

                int r = pc.Modificacion((Cliente)pUsuario);

                switch (r)
                {
                    case -1:
                        {
                            throw new Exception("No existe el cliente.");
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
            else
            {
                perEmpleado pe = new perEmpleado();

                int r = pe.Modificacion((Empleado)pUsuario);

                switch (r)
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

        public static Usuario Login(string pUsername, string pPassword)
        {
            Usuario u = null;

            perCliente pc = new perCliente();

            u = pc.Login(pUsername, pPassword);

            if (u.Equals(null))
            {
                perEmpleado pe = new perEmpleado();

                u = pe.Login(pUsername, pPassword);

                if (u.Equals(null))
                    throw new Exception("Usuario y/o contraseña incorrectos.");
            }

            return u;
        }
    }
}
