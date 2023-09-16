/*
 * Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********
*/
using System.Text;

namespace EjercicioI09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int altura;
            string asterisco = "*";
            string asteriscoDos = "*";
            string vacio = " ";
            StringBuilder sb = new StringBuilder();
            Console.Title = "Dibujando un triángulo equilátero";
            do
            {
                Console.WriteLine("Ingrese altura del triangulo");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out altura));
            if (altura > 1)
            {
                altura = altura * 2;
                // Recorro el alto de la pirámide
                for (int i = altura; i >= 0; i--)
                {
                    if (((altura - i) % 2) != 0)
                    {
                        // Recorro el ancho del piso de la pirámide
                        for (int j = 0; j < i / 2; j++)
                        {
                            Console.Write(" ");
                        }
                        // Recorro el ancho del piso de la pirámide
                        for (int j = 0; j < altura - i; j++)
                        {
                            Console.Write("*");
                        }
                        // Salto de línea
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Para poder dibujar un Triangulo ingrese una altura mayora 1");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}