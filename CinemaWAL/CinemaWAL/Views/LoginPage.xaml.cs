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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Ingresar_Click(object sender, EventArgs e)
        {
            var usuario = Usuario.Text;
            var password = Password.Text;


            if (string.IsNullOrEmpty(Usuario.Text))
            {
                await DisplayAlert("Validación", Languages.ValidarUsuario, "OK");
                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Validación", Languages.ValidarContraseña, "OK");
                return;
            }

            await Navigation.PushAsync(new CarteleraPage());
        }

    }
}