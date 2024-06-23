using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaVisitas : ContentPage
    {
        public ListaVisitas(Visita visita)
        {
            InitializeComponent();
            BindingContext = visita;
        }
    }
}