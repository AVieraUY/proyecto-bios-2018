using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Empleado: Usuario
    {
        private string _horarioTrabajo;
        private TimeSpan _horaInicio;
        private TimeSpan _horaFin;

        public string HorarioTrabajo
        {
            get
            {
                return _horarioTrabajo;
            }
            set
            {
                value = value.Trim();
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Error de capa 8.");
                _horarioTrabajo = value;
            }
        }

        public TimeSpan HoraInicio
        {
            get
            {
                return _horaInicio;
            }
            set
            {
                if ((value.Hours < 0 || value.Hours > 23) || value.Minutes < 0 || value.Minutes > 59)
                    throw new Exception("Debe ingresar una hora de ingreso válida.");
                _horaInicio = value;
            }
        }

        public TimeSpan HoraFin
        {
            get
            {
                return _horaFin;
            }
            set
            {
                if ((value.Hours < 0 || value.Hours > 23) || value.Minutes < 0 || value.Minutes > 59)
                    throw new Exception("Debe ingresar una hora de salida válida.");
                _horaFin = value;
            }
        }

        public Empleado(string pUsername, string pPassword, string pNombre, string pApellido, TimeSpan pHoraInicio, TimeSpan pHoraFin)
            : base(pUsername, pPassword, pNombre, pApellido)
        {
            HorarioTrabajo = "De " + pHoraInicio.ToString() + " a " + pHoraFin.ToString();
            HoraInicio = pHoraInicio;
            HoraFin = pHoraFin;
        }

        public override string ToString()
        {
            return base.ToString() + "\nHorario de trabajo: " + HorarioTrabajo + "\nHora de inicio: " + HoraInicio.ToString() + "\nHora de finalización: " + HoraFin.ToString();
        }
    }
}
