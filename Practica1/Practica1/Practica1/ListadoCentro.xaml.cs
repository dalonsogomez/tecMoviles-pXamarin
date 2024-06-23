using System;
using Xamarin.Forms;

namespace Practica1
{
    public partial class ListadoCentro : ContentPage
    {
        public ListadoCentro()
        {
            InitializeComponent();

            // Asigna la lista de usuarios a la ListView
            UsuariosListView.ItemsSource = App.Centro.Usuarios;
        }

        // Este método se llama cuando se selecciona un usuario de la lista
        async void OnUsuarioSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var usuarioSeleccionado = e.SelectedItem as Usuario;
            if (usuarioSeleccionado != null)
            {
                // Navega a la página de detalles de usuario
                await Navigation.PushAsync(new DetalleUsuario(usuarioSeleccionado));
            }
        }


    }
}