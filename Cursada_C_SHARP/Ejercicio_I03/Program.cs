using Operaciones;
/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int numero;
            string entrada;
            do
            {
                numero = Calculadora.PedirVerificarNumeroEnteroMayoACero();
                    if (numero < 2)
                    {
                        Console.WriteLine("PARA PODER LISTAR NUMERO PRIMOS INGRES ENTEROS MAYORES A 1");                   
                    }
                    int verificar;                    
                    for (verificar = 2; verificar <= numero; verificar++)
                    {
                        if(Calculadora.DeterminarNumeroPrimo(verificar))
                        {
                            Console.WriteLine("{0} es primo", verificar);
                        }
                    }
                    Console.WriteLine("Si desea volver a operar ingrese 'si'");
                    entrada = Console.ReadLine();
                    if (entrada != "si")
                    {
                        entrada = "salir";
                    }
            } while (entrada != "salir");
        }
    }
}