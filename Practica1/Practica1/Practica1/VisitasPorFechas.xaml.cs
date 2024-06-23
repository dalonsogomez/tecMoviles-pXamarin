using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Practica1
{
    public partial class VisitasPorFechas : ContentPage
    {
        List<Visita> visitasConcretas = new List<Visita>();

        public VisitasPorFechas()
        {
            InitializeComponent();
            datePickerFechaConcreta.MinimumDate = DateTime.Now;
        }

        void Button_ClickedMostrar(object sender, EventArgs e)
        {
            visitasConcretas.Clear();
            ListaVisitas.IsVisible = false;

            foreach (Visita visita in visitasConcretas)
            {

                if (visita.FechaVisita.Date == datePickerFechaConcreta.Date)
                {
                    visitasConcretas.Add(visita);
                }
            }

            if (visitasConcretas.Count > 0)
            {
                ListaVisitas.ItemsSource = visitasConcretas;
                ListaVisitas.IsVisible = true;
            }
            else
            {
                ListaVisitas.IsVisible = false;
                DisplayAlert("AVISO", "No hay ninguna actividad en esa fecha concreta", "Vale");
            }
        }

        void ListaVisitas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Visita visitaSeleccionada = e.SelectedItem as Visita;
            Navigation.PushAsync(new ListaVisitas(visitaSeleccionada));
        }

        async void Button_Clicked_Volver(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}