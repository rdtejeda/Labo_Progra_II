using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Calculadora
    {
        /// <summary>
        /// Pide y Verifica que el numero entero cargado sea mayor a 0
        /// </summary>
        /// <returns>Nuemero entero postivo verificado</returns>
        public static int PedirVerificarNumeroEnteroMayoACero()
        {            
            int valorIngresado;
            int verificador = -1;
            do
            {
                valorIngresado = Calculadora.PedirVerificarNumeroEntero();
                if (valorIngresado  >0)
                {
                    verificador = 0;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número Entero Mayor a 0!");
                }
            } while (verificador==-1);
            return valorIngresado;
        }
        /// <summary>
        /// Solicita un numero entero y verifica que lo sea
        /// </summary>
        /// <returns>El numero entero verificado</returns>
        public static int PedirVerificarNumeroEntero()
        {
            Console.WriteLine("Ingrese un numero; ");
            string respuesta = Console.ReadLine();
            int valorIngresado;
            while (!int.TryParse(respuesta, out valorIngresado))
            {
                Console.WriteLine("DEBE INGRESAR UN NUMERO ENTERO");
                respuesta = Console.ReadLine();
            }
            return valorIngresado;
        }
        /// <summary>
        /// Calcula el promedio sobre un total y con una cantidad a promediar
        /// </summary>
        /// <param name="acumulado">Total acumulado</param>
        /// <param name="cantidad">Cantidad de valores a promediar</param>
        /// <returns>Float con valor promedio</returns>
        public static float Promedio(float acumulado, int cantidad)
        {
            float retorno = acumulado / cantidad;
            return retorno;
        }
        /// <summary>
        /// Encuentra el mayor y el menor entre mas de un entero
        /// </summary>
        /// <param name="valorIngresado">Valor a comparar</param>
        /// <param name="menor">El menor de los enteros</param>
        /// <param name="mayor">El mayor de los enteros</param>
        /// <returns></returns>
        public static int[] EncotrarEnteroMayorYMenor(int valorIngresado, int menor, int mayor)
        {
            int[] menorYMayor = new int[2];
            menorYMayor[0] = menor;
            menorYMayor[1] = mayor;
            if (valorIngresado > mayor)
            {
                menorYMayor[1] = valorIngresado;
            }
            else
            {
                if (valorIngresado < menor)
                {
                    menorYMayor[0] = valorIngresado;
                }
            }
            return menorYMayor;
        }
        /// <summary>
        /// Determina si un mumero entero es primo
        /// </summary>
        /// <param name="verificar"></param>
        /// <returns>Retorna False si no lo es y True si es primo</returns>
        public static bool DeterminarNumeroPrimo(int verificar)
        {
            bool respuesta = false;
            int divisor;
            for (divisor = 2; divisor < verificar; divisor++) // Determino si es primo
            {
                if ((verificar % divisor) == 0) // Si tiene un divisor con resto cero, salgo ya que NO ES PRIMO
                {
                    break;
                }
            }
            if (divisor == verificar)
            {
              respuesta = true;
            }
            return respuesta;
        }        
    }
}