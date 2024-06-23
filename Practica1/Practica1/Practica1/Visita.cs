using System;

namespace Practica1
{
    public class Visita
    {
        public Visita(string actividad)
        {
            Actividad = actividad;
            FechaVisita = DateTime.Now; // Asumimos la fecha actual si no se proporciona
        }

        public Visita(string actividad, DateTime fechaVisita)
        {
            Actividad = actividad;
            FechaVisita = fechaVisita;
        }

        public string Actividad { get; set; }
        public DateTime FechaVisita { get; set; }

        public override string ToString()
        {
            return $"Actividad: {Actividad}, Fecha: {FechaVisita.ToString("d")}";
        }
    }
}