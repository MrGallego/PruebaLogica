using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLogica
{
    public class EjercicioUno
    {
        public static int SumaMultiplos(int n)
        {
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }

    }
}
