using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Palabra
    {
        private string cadena;

        public Palabra(string cadena)
        {
            this.cadena = cadena;
        }

        public Palabra()
        {
            this.cadena = string.Empty;
        }


        public string Reverse()
        {
            return this.reverse (this.cadena);
        }

        public string Reverse( string cadena )
        {
            return this.reverse(cadena);
        }

        private string reverse(string cadena)
        {
            string retorno = string.Empty;

            char[] charDePalabra = cadena.ToCharArray();
            Array.Reverse(charDePalabra);
            retorno = new string(charDePalabra);

            return retorno;

        }
    }
}
