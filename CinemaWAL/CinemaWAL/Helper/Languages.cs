

namespace CinemaWAL.Helper
{

    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            AppResource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }
        public static string Cartelera
        {
            get { return AppResource.Cartelera; }
        }

        public static string Contraseña
        {
            get { return AppResource.Contraseña; }
        }

        public static string DebeIngresarLaCantidadDeBoletas
        {
            get { return AppResource.DebeIngresarLaCantidadDeBoletas; }
        }

        public static string Usuario
        {
            get { return AppResource.Usuario; }
        }

        public static string ValidarContraseña
        {
            get { return AppResource.ValidarContraseña; }
        }

        public static string ValidarUsuario
        {
            get { return AppResource.ValidarUsuario; }
        }

        public static string FinalizarCompra
        {
            get { return AppResource.FinalizarCompra; }
        }

        public static string Estreno
        {
            get { return AppResource.Estreno; }
        }
        public static string Genero
        {
            get { return AppResource.Genero; }
        }

        public static string Recomendacion
        {
            get { return AppResource.Recomendacion; }
        }

        public static string Duracion
        {
            get { return AppResource.Duracion; }
        }

        public static string Cantidad
        {
            get { return AppResource.Cantidad; }
        }

        public static string Cinema
        {
            get { return AppResource.Cinema; }
        }

        public static string Ciudad
        {
            get { return AppResource.Ciudad; }
        }

        public static string Funcion
        {
            get { return AppResource.Funcion; }
        }

        public static string Precio
        {
            get { return AppResource.Precio; }
        }

        public static string Sala
        {
            get { return AppResource.Sala; }
        }

        public static string Tiquetes
        {
            get { return AppResource.Tiquetes; }
        }

        public static string TotalAPagar
        {
            get { return AppResource.TotalAPagar; }
        }

        public static string IniciarSesion
        {
            get { return AppResource.IniciarSesion; }
        }

        public static string TeDamosLaBienvenidaACinema
        {
            get { return AppResource.TeDamosLaBienvenidaACinema; }
        }

        public static string Titulo
        {
            get { return AppResource.Titulo; }
        }

        public static string Fecha
        {
            get { return AppResource.Fecha; }
        }

        public static string RecuperarContraseña
        {
            get { return AppResource.RecuperarContraseña; }
        }

        public static string Registrarme
        {
            get { return AppResource.Registrarme; }
        }

        public static string Funciones
        {
            get { return AppResource.Funciones; }
        }

        public static string Ingresar
        {
            get { return AppResource.Ingresar; }
        }

        public static string PeliculasEnCartelera
        {
            get { return AppResource.PeliculasEnCartelera; }
        }

        public static string Resumen
        {
            get { return AppResource.Resumen; }
        }
        public static string LaReservaSeHaGeneradoCorrectamente
        {
            get { return AppResource.LaReservaSeHaGeneradoCorrectamente; }
        }

        
    }

   
}
