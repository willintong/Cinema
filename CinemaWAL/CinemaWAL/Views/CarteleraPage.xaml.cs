using CinemaWAL.Domain;
using CinemaWAL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaWAL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarteleraPage : ContentPage
    {
        public CarteleraPage()
        {
            InitializeComponent();
            listPeliculas.ItemsSource = CinemaService.GetPelicula();
        }
        private async void Pelicula_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var pelicula = (Pelicula)e.SelectedItem;
            await Navigation.PushAsync(new FuncionesPage(pelicula));
        }
    }
}