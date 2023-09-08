namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta primerCuenta;
            primerCuenta = new Cuenta("Pepe Argento", 0.15f);

            Console.WriteLine($"Los datos de la cuenta son: \n{primerCuenta.CuentaToString()}");
            primerCuenta.IngresarDinero(234.455f);
            Console.WriteLine($"Los datos de la cuenta son: \n{primerCuenta.CuentaToString()}");
            primerCuenta.RetirarDinero(234.05f);
            Console.WriteLine($"Los datos de la cuenta son: \n{primerCuenta.CuentaToString()}");
        }
    }
}