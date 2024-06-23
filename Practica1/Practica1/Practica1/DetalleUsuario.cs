using Xamarin.Forms;
using System.Linq; // Asegúrate de incluir esto para usar métodos de LINQ

namespace Practica1
{
    public class DetalleUsuario : ContentPage
    {
        public DetalleUsuario(Usuario usuario)
        {
            Title = "Detalle del Usuario";

            var nombreLabel = new Label { Text = "Nombre: " + usuario.Nombre };
            var apellidosLabel = new Label { Text = "Apellidos: " + usuario.Apellidos };
            var fechaNacimientoLabel = new Label { Text = "Fecha de nacimiento: " + usuario.FechaNacimiento.ToString("d") };
            var esSocioLabel = new Label { Text = "Es socio: " + (usuario.EsSocio ? "Sí" : "No") };

            // Aquí convertimos cada visita a una descripción adecuada usando ToString()
            var visitasLabels = usuario.Visitas.Select(v => new Label { Text = v.ToString() }).ToList();

            var layout = new StackLayout
            {
                Padding = new Thickness(20),
                Children = { nombreLabel, apellidosLabel, fechaNacimientoLabel, esSocioLabel }
            };

            // Agregamos cada etiqueta de visita al layout
            foreach (var label in visitasLabels)
            {
                layout.Children.Add(label);
            }

            Content = layout;
        }
    }
}