using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class HelperParseador
    {
        public List<string> Parsear(string cadena, string[] separadores)
        {
            List<string> retorno = new List<string>();
            string palabraBuffer = string.Empty;

            for (int i = 0; i < cadena.Length; i++)
            {
                palabraBuffer = palabraBuffer + cadena[i];

                if (this.HayQueParsear( cadena[i], separadores ))
                {
                    retorno.Add(palabraBuffer);
                    palabraBuffer = string.Empty;
                }
            }
            return retorno;

        }

        private bool HayQueParsear(char caracter, string[] separadores)
        {
            bool retorno = false;
            foreach (string character in separadores)
            {
                retorno = (retorno || (caracter.ToString() == character));
            }

            return retorno;
        }
    }
}
