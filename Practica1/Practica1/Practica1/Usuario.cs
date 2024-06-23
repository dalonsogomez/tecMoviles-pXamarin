using System;
using System.Collections.Generic;

namespace Practica1
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsSocio { get; set; }
        public string Sexo { get; set; }

        // Lista de visitas realizadas por el usuario
        public List<Visita> Visitas { get; set; } = new List<Visita>();
        

        public Usuario()
        {
            Visitas = new List<Visita>();
        }
        public Usuario(string codigoUsuario, string nombre, string apellidos, DateTime fechaNacimiento, bool socio, string sexo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            EsSocio = socio;
            Sexo = sexo;
            Visitas = new List<Visita>();
        }
    }
    
}