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
                _telefono = value;
            }
        }

        public Cliente(string pUsername, string pPassword, string pNombreCompleto, string pDireccionEntrega, string pTelefono)
            :base(pUsername, pPassword, pNombreCompleto)
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
