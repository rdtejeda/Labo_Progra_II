using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calcular
    {
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
        /// Encuentra el mayor y el menor de mas de un entero
        /// </summary>
        /// <param name="valorIngresado">Valor a comparar</param>
        /// <param name="menor">El menor de los enteros</param>
        /// <param name="mayor">El mayor de los enteros</param>
        /// <returns></returns>
        public static int[] EncotrarEnteroMayorYMenor(int valorIngresado,  int menor, int mayor)
        {
            int[] menorYMayor= new int[2];
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
            return menorYMayor ;
        }
    }
}