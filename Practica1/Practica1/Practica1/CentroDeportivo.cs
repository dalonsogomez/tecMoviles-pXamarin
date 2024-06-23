using System.Collections.Generic;
using System.Linq;

namespace Practica1
{
    public class CentroDeportivo
    {
        private List<Usuario> usuarios;

        public CentroDeportivo()
        {
            usuarios = new List<Usuario>();
        }

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
        }


        public bool EliminarUsuario(string codigoUsuario)
        {
            var usuarioAEliminar = usuarios.FirstOrDefault(u => u.CodigoUsuario == codigoUsuario);
            if (usuarioAEliminar != null)
            {
                usuarios.Remove(usuarioAEliminar);
                return true;
            }
            return false;
        }
    }
}