namespace Clase_02

/*
Crear la clase TextOperations y sus métodos estáticos para trabajar con cadenas.
Métodos:



● string ReemplazarCaracter(string palabra, char original, char nuevo): Reemplaza el carácter original por el indicado.
● bool ConvertirStringAEntero(string texto, int xxx numeroEntero): Devuelve si es posible convertir un texto a entero y si es posible lo devuelve en la variable numeroEntero.
● StringBuilder ConvertirStringASB(string palabra): Recibe un string y lo guarda en un StringBuilder.
● StringBuilder ConvertirParrafoASB(string parrafo): Recibe un párrafo y guarda cada frase en una línea nueva de un StringBuilder. Cada frase finaliza cuando encontramos un punto (.).
● void MostrarTexto(string mensaje, string texto): Muestra por consola el mensaje y el texto recibido.
● void MostrarTextoSB(StringBuilder texto): Muestra por consola el texto recibido.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "Son unas cuantas";
            Console.WriteLine("La palabra contiene {0} letras", OperarTexto.ContarLetras(palabra));
            OperarTexto.ContarPalabras("Este texto tiene, sin contar las comas, nueve palabras");
            string palabra2 = "AeEighIoOjjjUu";
            Console.WriteLine("La palabra contiene {0} vocales", OperarTexto.ContarVocales(palabra2));
            Console.WriteLine("la palabra contiene {0} consonantes", OperarTexto.ContarConsonantes(palabra2));
        }
    }
}