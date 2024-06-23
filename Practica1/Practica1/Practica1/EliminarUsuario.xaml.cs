using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EliminarUsuario : ContentPage
    {
        CentroDeportivo centroDeportivo;

        public EliminarUsuario(CentroDeportivo centro)
        {
            InitializeComponent();
            centroDeportivo = centro;
        }

        async void OnEliminarButtonClicked(object sender, EventArgs e)
        {
            string codigoUsuario = CodigoUsuarioEntry.Text; // Asumiendo que CodigoUsuarioEntry es un Entry que contiene el texto del código del usuario
            if (!string.IsNullOrWhiteSpace(codigoUsuario))
            {
                bool resultado = centroDeportivo.EliminarUsuario(codigoUsuario);
                if (resultado)
                {
                    await DisplayAlert("Éxito", "Usuario eliminado con éxito", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "Usuario no encontrado", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, introduce un código de usuario válido", "OK");
            }
        }
    }
}