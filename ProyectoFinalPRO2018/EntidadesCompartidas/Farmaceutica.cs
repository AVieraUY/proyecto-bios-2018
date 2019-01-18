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
