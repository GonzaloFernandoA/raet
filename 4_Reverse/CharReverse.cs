using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Reverse
{
  public class CharReverse
  {
    /// <summary>
    /// Reverses the characters in each word in the sentence, while keeping the same order of words.
    /// The words are delimited by: space, comma, dot
    /// eg: The quick brown fox ==> ehT kciuq nworb xof
    /// </summary>
    /// <param name="input">String to reverse words in.</param>
    /// <returns>The string containing reversed words.</returns>
      public string Reverse(string input)
      {
          string resultado = string.Empty;

          Parrafo parrafo = new Parrafo();
          List<Oracion> oraciones = parrafo.Parsear(input);
          foreach (Oracion oracion in oraciones)
          {
              foreach (Palabra palabra in oracion.Parsear())
              {
                  resultado = resultado + palabra.Reverse();
              }
          }

          return resultado;
      }
  }
}