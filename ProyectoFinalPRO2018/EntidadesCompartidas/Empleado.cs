using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Empleado: Usuario
    {
        private string _horarioTrabajo;
        private string _horaInicio;
        private string _horaFin;

        public string HorarioTrabajo
        {
            get
            {
                return _horarioTrabajo;
            }
            set
            {
                _horarioTrabajo = value;
            }
        }

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

        public Empleado(string pUsername, string pPassword, string pNombreCompleto, string pHorarioTrabajo, string pHoraInicio, string pHoraFin)
            : base(pUsername, pPassword, pNombreCompleto)
        {
            HorarioTrabajo = pHorarioTrabajo;
            HoraInicio = pHoraInicio;
            HoraFin = pHoraFin;
        }

        public override string ToString()
        {
            return base.ToString() + "\nHorario de trabajo: " + HorarioTrabajo + "\nHora de inicio: " + HoraInicio + "\nHora de finalización: " + HoraFin;
        }
    }
}
