using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class StringService
    {
        public static int ContadorDeCaracteres(string texto)
        {
            int totalDeCaracteres = texto.Length;
            return totalDeCaracteres;
        }
    }
}
