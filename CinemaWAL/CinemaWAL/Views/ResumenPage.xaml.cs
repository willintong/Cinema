using CinemaWAL.Domain;
using CinemaWAL.Helper;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaWAL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResumenPage : ContentPage
    {
        private SeleccionPelicula seleccionPelicula;
        
        public ResumenPage(SeleccionPelicula seleccionPelicula, int cantidad)
        {
        
            InitializeComponent();
            this.seleccionPelicula = seleccionPelicula;
            BindingContext = seleccionPelicula;
            TotalPagar.Text = (cantidad * seleccionPelicula.Tiquetes.Precio).ToString();
        }
        private async void Finalizar_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Bien hecho!", Languages.LaReservaSeHaGeneradoCorrectamente, "OK");
        }
    }
}