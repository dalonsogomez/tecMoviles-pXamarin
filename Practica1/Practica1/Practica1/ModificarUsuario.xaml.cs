using System;
using System.Collections.Generic;
using Practica1;
using Xamarin.Forms;

namespace Practica1
{
    public partial class ModificarUsuario : ContentPage
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        async void ModificarUsuarioClicked(System.Object sender, System.EventArgs e)
        {
            bool nomEncontrado = false;
            int cont = 0;

            if (String.IsNullOrEmpty(entryUsuario.Text))
            {
                await DisplayAlert("AVISO", "Introduce un el código de un usuario", "VALE");
            }
            else
            {
                foreach (Usuario a in App.Centro.Usuarios)
                {
                    if (a.Nombre.Equals(entryUsuario.Text))
                    {
                        nomEncontrado = true;
                        break;
                    }
                    cont++;
                }
                if (!nomEncontrado)
                {
                    await DisplayAlert("AVISO", "No se ha encontrado ningun usuario con ese código" + entryUsuario.Text, "VALE");
                }
                else
                {
                    Usuario usuarioEncontrado = App.Centro.Usuarios[cont];

                    if (usuarioEncontrado.EsSocio == true)
                    {
                        usuarioEncontrado.EsSocio = false;

                        await DisplayAlert("AVISO", "El usuario con el código" + entryUsuario.Text + " ya NO es socio", "VALE");
                    }
                    else
                    {
                        usuarioEncontrado.EsSocio = true;

                        await DisplayAlert("AVISO", "El usuario con el código" + entryUsuario.Text + " ahora SÍ es socio", "VALE");
                    }

                    limpiar();
                }
            }
        }

        private void limpiar()
        {
            entryUsuario.Text = string.Empty;
        }
    }
}
