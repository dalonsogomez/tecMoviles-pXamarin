using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using System;

namespace Practica1
{
    public partial class App : Application
    {
        public static CentroDeportivo Centro { get; private set; } // La propiedad ahora es de solo lectura
        public static List<Visita> Visitas = new List<Visita>();

        public App()
        {
            InitializeComponent();

            // Inicializa el Centro Deportivo y su lista interna de usuarios
            Centro = new CentroDeportivo();

            // Define la página principal de la aplicación
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Manejar lógica al iniciar la aplicación, si es necesario
        }

        protected override void OnSleep()
        {
            // Manejar lógica al poner la app en segundo plano, si es necesario
        }

        protected override void OnResume()
        {
            // Manejar lógica al reanudar la app desde segundo plano, si es necesario
        }
        
    }
}