using System;
using Xamarin.Forms;

namespace Practica1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnAgregarNuevosUsuarioClicked(object sender, EventArgs e)
        {
            // Navega a la página de alta de usuarios
            await Navigation.PushAsync(new AgregarNuevosUsuario());
        }

        async void OnAltaNuevasVisitasClicked(object sender, EventArgs e)
        {
            // Navega a la página de alta de visitas
            await Navigation.PushAsync(new AltaNuevasVisitas());
        }
       

        async void OnListadoCentroClicked(object sender, EventArgs e)
        {
            // Navega a la página de listado de usuarios
            await Navigation.PushAsync(new ListadoCentro());
        }

        private async void OnVisitasPorFechasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VisitasPorFechas());
        }

        async void OnEliminarButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EliminarUsuario(App.Centro));
        }

        private async void OnModificarUsuarioClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModificarUsuario());
        }

    }
}