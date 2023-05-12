using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLogica
{
    public class EjercicioDos
    {
        public static string CamelCase(string s)
        {
            string[] palabras = s.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            string resultado = palabras[0].ToLower();
            for (int i = 1; i < palabras.Length; i++)
            {
                resultado += palabras[i].Substring(0, 1).ToUpper() + palabras[i].Substring(1).ToLower();
            }
            return resultado;
        }

    }
}
