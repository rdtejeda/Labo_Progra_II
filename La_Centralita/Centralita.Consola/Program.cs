namespace Centralita.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Centralita c = new Centralita("Fede Center");
            Centralita cdos = new Centralita();
            
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.EFranja.Franja_3, l2);
            LLamada l5 = new Local("Quilmes", 10, "La plata", 3.67f);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l5);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine("===== VOY A ORDENAR LA LISTA =====");
            Console.WriteLine(c.Mostrar());

            Console.ReadKey(); 
        }
    }
}