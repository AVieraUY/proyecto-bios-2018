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
            if(pUsuario is Cliente)
            {
                perCliente pc = new perCliente();
                pc.Alta((Cliente)pUsuario);

            }
            else
            {
                perEmpleado pe = new perEmpleado();
                pe.Alta((Empleado)pUsuario);

            }
        }

        public static void Baja(Empleado emp)
        {
            perEmpleado pe = new perEmpleado();
            pe.Baja(emp);

        }

        public static Usuario Buscar(string pUsername)
        {
            Usuario u = null;

           // perCliente pc = new perCliente();

            //u = pc.Buscar(pUsername);

           // if(u.Equals(null))
            //{
                perEmpleado pe = new perEmpleado();

                u = pe.Buscar(pUsername);

                if (u.Equals(null))
                    throw new Exception("No existe el usuario.");
           // }

            return u;
        }

        public static void Modificacion(Empleado emp)
        {
                perEmpleado pe = new perEmpleado();
                pe.Modificacion(emp);

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
