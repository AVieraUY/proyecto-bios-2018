using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Empleado: Usuario
    {
       // private string _horarioTrabajo;
        private DateTime _horaInicio;
        private DateTime _horaFin;

        //public string HorarioTrabajo
        //{
        //    get
        //    {
        //        return _horarioTrabajo;
        //    }
        //    set
        //    {
        //        value = value.Trim();
        //        if (String.IsNullOrEmpty(value))
        //            throw new Exception("Error desconocido.");
        //        _horarioTrabajo = value;
        //    }
        //}

        public DateTime HoraInicio
        {
            get
            {
                return _horaInicio;
            }
            set
            {
               // if ((value.ToShortTimeString  || value.Hours > 23) || value.Minutes < 0 || value.Minutes > 59)
                //    throw new Exception("Debe ingresar una hora de ingreso válida.");
                _horaInicio = value;
            }
        }

        public DateTime HoraFin
        {
            get
            {
                return _horaFin;
            }
            set
            {
             //   if ((value.Hours < 0 || value.Hours > 23) || value.Minutes < 0 || value.Minutes > 59)
               //     throw new Exception("Debe ingresar una hora de salida válida.");
                _horaFin = value;
            }
        }

        public Empleado(string pUsername, string pPassword, string pNombre, string pApellido, DateTime pHoraInicio, DateTime pHoraFin)
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
