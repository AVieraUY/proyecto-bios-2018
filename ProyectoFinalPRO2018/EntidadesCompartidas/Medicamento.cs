using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Medicamento
    {
        private Farmaceutica _farmaceutica;
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;

        public Farmaceutica Farmaceutica
        {
            get
            {
                return _farmaceutica;
            }
            set
            {
                _farmaceutica = value;
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
                _codigo = value;
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

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public Medicamento(Farmaceutica pFarmaceutica, int pCodigo, string pNombre, string pDescripcion, decimal pPrecio)
        {
            Farmaceutica = pFarmaceutica;
            Codigo = pCodigo;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Precio = pPrecio;
        }

        public override string ToString()
        {
            return "Farmaceutica: " + Farmaceutica.Nombre + "\nCódigo: " + Codigo + "\nNombre: " + Nombre + "\nDescripción: " + Descripcion + "\nPrecio: " + Precio;
        }
    }
}
