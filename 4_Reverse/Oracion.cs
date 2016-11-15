using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Oracion
    {
        private string input;
        public Oracion(string cadena)
        {
            this.input = cadena;
        }
        public List<Palabra> Parsear()
        {
            List<Palabra> ListaDePalabras = new List<Palabra>();
            string palabraBuffer = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                palabraBuffer = palabraBuffer + input[i];

                if (input[i] == ' ' || input[i] == ',')
                {
                    ListaDePalabras.Add(new Palabra (palabraBuffer ));
                    palabraBuffer = string.Empty;
                }
            }
            return ListaDePalabras;
        }
    }
}
