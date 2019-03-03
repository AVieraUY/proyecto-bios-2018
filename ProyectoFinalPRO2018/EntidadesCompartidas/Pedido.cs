using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Pedido
    {
        private Medicamento _medicamento;
        private Cliente _cliente;
        private int _codigo;
        private int _cantidad;
        private string _estado;

        public Medicamento Medicamento
        {
            get
            {
                return _medicamento;
            }
            set
            {
                if (value.Equals(null))
                    throw new Exception("Error desconocido.");
                _medicamento = value;
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
                if (value.Equals(null))
                    throw new Exception("Error desconocido.");
                _cliente = value;
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

        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                if (value != ("Generado") && value != ("Enviado") && value != ("Entregado"))
                    throw new Exception("Error desconocido.");
                _estado = value;
            }
        }

        public Pedido(Medicamento pMedicamento, Cliente pCliente, int pCodigo, int pCantidad, string pEstado)
        {
            Medicamento = pMedicamento;
            Cliente = pCliente;
            Codigo = pCodigo;
            Cantidad = pCantidad;
            Estado = pEstado;
        }

        public override string ToString()
        {
            return "Medicamento: " + Medicamento.Nombre + "\nCliente: " + Cliente.NombreCompleto + "\nMedicamento: " + Codigo + "\nCantidad: " + Cantidad + "\nEstado: " + Estado;
        }
    }
}
