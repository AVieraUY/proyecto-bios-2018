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
