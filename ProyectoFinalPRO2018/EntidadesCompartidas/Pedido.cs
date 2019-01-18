using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Pedido
    {
        private int _numero;
        private Cliente _cliente;
        private Medicamento _medicamento;
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
                _numero = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
            }
        }

        public Medicamento Medicamento
        {
            get
            {
                return _medicamento;
            }
            set
            {
                _medicamento = value;
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
                _estado = value;
            }
        }

        public Pedido(int pNumero, Cliente pCliente, Medicamento pMedicamento, int pCantidad, byte pEstado)
        {
            Numero = pNumero;
            Cliente = pCliente;
            Medicamento = pMedicamento;
            Cantidad = pCantidad;
            Estado = pEstado;
        }

        public override string ToString()
        {
            return "Número: " + Numero + "\nCliente: " + Cliente.NombreCompleto + "\nMedicamento: " + Medicamento.Nombre + "\nCantidad: " + Cantidad + "\nEstado: " + Estado;
        }
    }
}
