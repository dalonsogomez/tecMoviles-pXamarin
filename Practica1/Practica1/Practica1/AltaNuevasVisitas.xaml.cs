using System;
using System.Linq;
using Xamarin.Forms;

namespace Practica1
{
    public partial class AltaNuevasVisitas : ContentPage
    {
        public AltaNuevasVisitas()
        {
            InitializeComponent();
            FechaVisitaPicker.MinimumDate = DateTime.Now;
        }

        async void AltaNuevasVisitasClicked(System.Object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(entryCodigoUsuario.Text) || pickerActividad.SelectedItem == null)
            {
                await DisplayAlert("AVISO", "Introduce todos los campos", "Vale");
                return;
            }

            var usuarioEncontrado = App.Centro.Usuarios.FirstOrDefault(u => u.CodigoUsuario == entryCodigoUsuario.Text);

            if (usuarioEncontrado != null)
            {
                var tipoActividad = (string)pickerActividad.SelectedItem;
                var nuevaVisita = new Visita(tipoActividad, FechaVisitaPicker.Date);
                usuarioEncontrado.Visitas.Add(nuevaVisita);

                await DisplayAlert("AVISO", "Las actividades se han inscrito correctamente", "Vale");
                limpiar();
            }
            else
            {
                await DisplayAlert("AVISO", "No existe ningún usuario con el código " + entryCodigoUsuario.Text, "Vale");
            }
        }

        private void limpiar()
        {
            entryCodigoUsuario.Text = string.Empty;
            pickerActividad.SelectedItem = null;
            FechaVisitaPicker.Date = DateTime.Now;
        }
    }
}