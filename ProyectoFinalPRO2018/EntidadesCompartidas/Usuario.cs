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
        private string _nombre;
        private string _apellido;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                value = value.Trim();
                if (value.Equals(String.Empty) || value.Length < 6)
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
                if((value.Equals(String.Empty)) || (value.Length < 6))
                    throw new Exception("Debe ingresar una contraseña válida.");
                _password = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar un nombre correcto.");
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar un apellido correcto.");
                _apellido = value;
            }
        }

        public Usuario(string pUsername, string pPassword, string pNombre, string pApellido)
        {
            Username = pUsername;
            Password = pPassword;
            Nombre = pNombre;
            Apellido = pApellido;
        }

        public override string ToString()
        {
            return "Username: " + Username + "\nPassword: " + Password;
        }
    }
}
