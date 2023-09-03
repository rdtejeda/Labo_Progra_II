using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    internal class OperarTexto
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
        /// Cuenta la cantidad de palabras que contiene el texto;● int ContarPalabras(string texto): Cuenta la cantidad de palabras que contiene el texto;
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static int ContarPalabras(string texto)
        {
            int retorno = 0;
            // Divide el texto en palabras utilizando espacios como separadores
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);         // Cuenta la cantidad de palabras
            int cantidadPalabras = palabras.Length;
            Console.WriteLine($"La cantidad de palabras en el texto es: {cantidadPalabras}");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            return retorno;
        }
        /// <summary>
        /// Cuenta la cantidad de vocales que contiene una palabra
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static int ContarVocales(string palabra)
        {
            int retorno=0;
            foreach (char a in palabra)
            {
                if (Char.IsLetter(a) && (a=='a' || a == 'A' || a=='e') || a == 'E' || a == 'i' || a == 'I' || a == 'o' || a == 'O' || a == 'u' || a == 'U')
                {
                    retorno++;
                }
            }
            return retorno;
        }
        /// <summary>
        /// ● int ContarConsonantes(string palabra): Cuenta la cantidad de consonantes que contiene una palabra.
        /// </summary>
        /// <param name="papalabra"></param>
        /// <returns></returns>
        public static int ContarConsonantes(string papalabra)
        {
            return ContarLetras(papalabra)-ContarVocales(papalabra);
        }
    }
}
