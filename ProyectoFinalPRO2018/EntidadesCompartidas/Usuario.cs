using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public abstract class Usuario
    {
        private string _username;
        private string _password;
        private string _nombreCompleto;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                value = value.Trim();
                if (value.Equals(String.Empty) || value.Length < 3)
                    throw new Exception("Debe ingresar un nombre de usuario válido.");
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                value = value.Trim();
                if((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar una contraseña válida.");
                _password = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return _nombreCompleto;
            }
            set
            {
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar el nombre completo.");
                _nombreCompleto = value;
            }
        }

        public Usuario(string pUsername, string pPassword, string pNombreCompleto)
        {
            Username = pUsername;
            Password = pPassword;
            NombreCompleto = pNombreCompleto;
        }

        public override string ToString()
        {
            return "Username: " + Username + "\nPassword: " + Password + "\nNombre completo: " + NombreCompleto;
        }
    }
}
