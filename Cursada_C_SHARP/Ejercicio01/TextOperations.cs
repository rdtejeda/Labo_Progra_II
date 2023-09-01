using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class TextOperations
    {
        /// <summary>
        /// Cuenta la cantidad de letras que tiene una palabra.
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>cantidad de letras</returns>
        public static int ContarLetras(string palabra)
        {
            int retorno = 0;
            foreach (char a in palabra)
            {
                if (Char.IsLetter(a))
                {
                    retorno++;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Cuenta la cantidad de palabras que contiene el texto;
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static int ContarPalabras(string texto)
        {
            int retorno = 0;

            return retorno;
        }
    }
}
