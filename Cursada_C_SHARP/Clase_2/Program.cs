using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            if(DeterminarParidad(numero))
            {
                Console.WriteLine("El numero es impar");
            }
            else
            {
                Console.WriteLine("El numero espar");
            }


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("pepe");
            sb.AppendLine("jose");
            sb.AppendLine("luis");
            Console.WriteLine(sb);
            string nombre = "comko te llames";
            char[] arrayNombre = nombre.ToCharArray();
            
            string p= "j";
            p.Contains("d");
            String.Compare("d", "y");
            nombre.IndexOf('d');

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        /// <exception cref="IOExceptio"></exception>
        
        public static bool DeterminarParidad(int numero)
        {
            bool result = false;
            if (numero %2 ==0) 
            {
                result = true;
            }
            return result;
            //return(numero %2 == 0);
        }
        public static void HacerAlgo(string nombre)
        {

        }
    }
}
