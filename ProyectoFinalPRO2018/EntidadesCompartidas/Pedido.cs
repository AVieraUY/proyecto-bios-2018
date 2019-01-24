using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Pedido
    {
        private int _numero;
        private string _username;
        private int _codigo;
        private int _cantidad;
        private byte _estado;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Error desconocido.");
                _numero = value;
            }
        }

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

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Debe ingresar un código válido.");
                _codigo = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Debe ingresar una cantidad válida.");
                _cantidad = value;
            }
        }

        public byte Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                if (value != 1 || value != 2 || value != 3)
                    throw new Exception("Error desconocido.");
                _estado = value;
            }
        }

        public Pedido(int pNumero, string pUsername, int pCodigo, int pCantidad, byte pEstado)
        {
            Numero = pNumero;
            Username = pUsername;
            Codigo = pCodigo;
            Cantidad = pCantidad;
            Estado = pEstado;
        }

        public override string ToString()
        {
            return "Número: " + Numero + "\nCliente: " + Username + "\nMedicamento: " + Codigo + "\nCantidad: " + Cantidad + "\nEstado: " + Estado;
        }
    }
}
