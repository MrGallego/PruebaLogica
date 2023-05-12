using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLogica
{
    public class EjercicioTres
    {
        public static string ReverseLongWords(string frase)
        {
            string[] palabras = frase.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 5)
                {
                    palabras[i] = new string(palabras[i].Reverse().ToArray());
                }
            }
            return string.Join(" ", palabras);
        }

    }
}
