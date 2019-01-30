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
                if (value.Equals(null))
                    throw new Exception("Error desconocido.");
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
                if (value <= 0)
                    throw new Exception("Debe ingresar un código válido.");
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
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar un nombre válido.");
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
                value = value.Trim();
                if ((value.Equals(String.Empty)) || (value.Length < 3))
                    throw new Exception("Debe ingresar una descripción válida.");
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
                if (value <= 0)
                    throw new Exception("Debe ingresar un precio válido.");
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
            return "Farmaceutica: " + Farmaceutica.Ruc + "\nCódigo: " + Codigo + "\nNombre: " + Nombre + "\nDescripción: " + Descripcion + "\nPrecio: " + Precio;
        }
    }
}
