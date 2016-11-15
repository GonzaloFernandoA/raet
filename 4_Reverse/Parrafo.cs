using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Parrafo
    {
        public List<Oracion> Parsear(string parrafo)
        {
            List<Oracion> oraciones = new List<Oracion>();
            string oracionBuffer = string.Empty;

            for (int i = 0; i < parrafo.Length; i++)
            {
                oracionBuffer = oracionBuffer + parrafo[i];
                if (parrafo[i] == '.')
                {
                    oraciones.Add(new Oracion(oracionBuffer));
                    oracionBuffer = string.Empty;
                }
            }

            return oraciones;
        }
    }
}
