using Calculadora;

namespace Primer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorIngresado;
            int contador=0;
            int acumulador=0;
            int[] menorYMayor = new int[2];
            menorYMayor[0] = int.MaxValue;
            menorYMayor[1] = int.MinValue;
            do
            {
                valorIngresado = Calcular.PedirVerificarNumeroEntero();
                acumulador = acumulador+valorIngresado;
                contador++;
                menorYMayor = Calcular.EncotrarEnteroMayorYMenor(valorIngresado, menorYMayor[0], menorYMayor[1]); ;
            } while (contador < 5);
            Console.WriteLine($"El promedio de los {contador} números ingresados es {Calcular.Promedio((float)acumulador, contador)}");
            Console.WriteLine($"El menor de los numeros ingresado es el {menorYMayor[0]} - El mayor de los nuemero ingresado es el {menorYMayor[1]}");
        }
    }
}