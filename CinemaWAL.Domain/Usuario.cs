using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWAL.Domain
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string Password { get; set; }

        public static implicit operator string(Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}
