using System;
using System.Collections.Generic;

namespace Practica1
{
	public class ListaUsuarios
	{
        public List<Usuario> Usuarios { get; set; }

        public ListaUsuarios()
        {
            // Inicializar la lista en el constructor.
            Usuarios = new List<Usuario>();
        }
    }
}

