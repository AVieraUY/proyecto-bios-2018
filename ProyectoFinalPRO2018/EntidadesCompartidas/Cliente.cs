using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Cliente: Usuario
    {
        private string _direccionEntrega;
        private string _telefono;

        public string DireccionEntrega
        {
            get
            {
                return _direccionEntrega;
            }
            set
            {
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar una dirección válida.");
                _direccionEntrega = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                value = value.Trim();
               // if ((value.Length < 3 || (!value.StartsWith("09")) || (!value.StartsWith("2")) || (!value.StartsWith("4"))))
                if (value.Length < 3)   
                throw new Exception("Debe ingresar un teléfono válido.");
                _telefono = value;
            }
        }

        public Cliente(string pUsername, string pPassword, string pNombre, string pApellido, string pDireccionEntrega, string pTelefono)
            :base(pUsername, pPassword, pNombre, pApellido)
        {
            DireccionEntrega = pDireccionEntrega;
            Telefono = pTelefono;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDireccion entrega: " + DireccionEntrega + "\nTeléfono: " + Telefono;
        }
    }
}
