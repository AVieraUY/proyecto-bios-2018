using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Empleado: Usuario
    {
        private string _horaInicio;
        private string _horaFin;
        
        public string HoraInicio
        {
            get
            {
                return _horaInicio;
            }
            set
            {
                _horaInicio = value;
            }
        }

        public string HoraFin
        {
            get
            {
                return _horaFin;
            }
            set
            {
                _horaFin = value;
            }
        }

        public Empleado(string pUsername, string pPassword, string pNombre, string pApellido, string pHoraInicio, string pHoraFin)
            : base(pUsername, pPassword, pNombre, pApellido)
        {
            HoraInicio = pHoraInicio;
            HoraFin = pHoraFin;
        }

        public override string ToString()
        {
            return base.ToString() + "\nHorario de trabajo: " + "\nHora de inicio: " + HoraInicio.ToString() + "\nHora de finalización: " + HoraFin.ToString();
        }
    }
}
