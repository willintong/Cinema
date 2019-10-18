using CinemaWAL.Domain;
using CinemaWAL.Helper;
using CinemaWAL.Resources;
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
    public partial class FuncionesPage : ContentPage
    {
        private Pelicula pelicula;

        public FuncionesPage(Pelicula pelicula)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            BindingContext = pelicula;
        }

        private async void Funcion_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(BoletasDisponibles.Text))
            {
                await DisplayAlert("Validación", Languages.DebeIngresarLaCantidadDeBoletas, "OK");
                return;
            }
            SeleccionPelicula seleccionPelicula = new SeleccionPelicula();
            Funcion funcion1 = (Funcion)e.SelectedItem;
            seleccionPelicula.Titulo = pelicula.Nombre;
            seleccionPelicula.Imagen = pelicula.Imagen;
            seleccionPelicula.FechaEstreno = pelicula.FechaEstreno;
            seleccionPelicula.Funciones = funcion1;
            Tiquetes tqt = new Tiquetes();
            tqt.Cantidad = System.Convert.ToInt32(BoletasDisponibles.Text);
            tqt.Precio = funcion1.Precio;
            seleccionPelicula.Tiquetes = tqt;


            await Navigation.PushAsync(new ResumenPage(seleccionPelicula, tqt.Cantidad));
        }
    }
}