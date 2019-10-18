using CinemaWAL.Domain;
using CinemaWAL.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWAL.Service
{
    class CinemaService
    {

        public static List<Autenticacion> GetAutenticacion(Usuario usuario)
        {
            var autenticacions = ApiHelper.Post<List<Autenticacion>>("/api/Seguridad",usuario);
            return autenticacions;

        }

        public static List<Pelicula> GetPelicula()
        {
            var peliculas = ApiHelper.Get<List<Pelicula>>("/api/Cartelera");
            return peliculas;

        }
    }
}
