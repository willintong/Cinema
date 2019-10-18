using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWAL.Domain
{
    public class SeleccionPelicula
    {
        public string  Titulo { get; set; }
        public DateTime  FechaEstreno { get; set; }
        public string Imagen { get; set; }
        public Funcion Funciones { get; set; }
        public Tiquetes Tiquetes { get; set; }
    }
}
