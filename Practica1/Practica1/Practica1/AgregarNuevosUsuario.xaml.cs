using System;
using System.Linq;
using Xamarin.Forms;

namespace Practica1
{
    public partial class AgregarNuevosUsuario : ContentPage
    {
        public AgregarNuevosUsuario()
        {
            InitializeComponent();
        }

        async void OnRegistrarClicked(object sender, EventArgs e)
        {
            var nuevoUsuario = new Usuario
            {
                CodigoUsuario = CodigoUsuarioEntry.Text,
                Nombre = NombreEntry.Text,
                Apellidos = ApellidosEntry.Text,
                FechaNacimiento = FechaNacimientoPicker.Date,
                EsSocio = EsSocioSwitch.IsToggled,
                Sexo = (string)SexoPicker.SelectedItem
            };

            if (ValidarCodigoUnico(nuevoUsuario.CodigoUsuario))
            {
                App.Centro.Usuarios.Add(nuevoUsuario);
                await DisplayAlert("Registro", "Usuario registrado exitosamente", "OK");
                limpiarCampos();
            }
            else
            {
                await DisplayAlert("Error", "Código de usuario duplicado", "OK");
            }
        }

        private void limpiarCampos()
        {
            CodigoUsuarioEntry.Text = string.Empty;
            NombreEntry.Text = string.Empty;
            ApellidosEntry.Text = string.Empty;
            FechaNacimientoPicker.Date = DateTime.Today;
            EsSocioSwitch.IsToggled = false;
            SexoPicker.SelectedItem = null;
        }

        bool ValidarCodigoUnico(string codigo)
        {
            return App.Centro.Usuarios.All(u => u.CodigoUsuario != codigo);
        }
    }
}