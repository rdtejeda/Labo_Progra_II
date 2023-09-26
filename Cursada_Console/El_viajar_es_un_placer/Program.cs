namespace El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Automovil vehiculoUno = new Automovil(4,4,EColor.Azul,6,8);
           Console.WriteLine( vehiculoUno.ToSring());
            
        }
    }
}