using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Farmaceutica
    {
        private int _ruc;
        private string _nombre;
        private string _correo;
        private string _direccion;

        public int Ruc
        {
            get
            {
                return _ruc;
            }
            set
            {
                string rutStr = value.ToString();
                if ((rutStr.Length < 12) || (value == 0))
                    throw new Exception("Debe ingresar un RUT válido.");
                _ruc = value;
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
                    throw new Exception("Debe ingresar un nombre válido.");
                _nombre = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }
            set
            {
                value = value.Trim();
                if ((value.Length < 3) || !(value.Contains("@")) || !(value.Contains(".")))
                    throw new Exception("Debe ingresar un correo válido.");
                _correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar una dirección válida.");
                _direccion = value;
            }
        }

        public Farmaceutica(int pRuc, string pNombre, string pCorreo, string pDireccion)
        {
            Ruc = pRuc;
            Nombre = pNombre;
            Correo = pCorreo;
            Direccion = pDireccion;
        }

        public override string ToString()
        {
            return "RUC: " + Ruc + "\nNombre: " + Nombre + "\nCorreo: " + Correo + "\n Dirección: " + Direccion;
        }

    }
}
