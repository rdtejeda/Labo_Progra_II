using Celulares;

namespace Clase_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> agenda = new List<string>();
            agenda.Add("1111");
            agenda.Add("2222");
            Contacto uncontacto = new Contacto("Pepe", "1111");
            Celularess celularUno = new Celularess(EMarca.Apple, "14",8,128,true,agenda);
            Celularess celularDos = new Celularess(EMarca.Samsung, "S23", 32, 256,false);
            Celularess celularTres = new Celularess();

           celularTres.Modelo=" celulJAJJAJAS20";
            Console.WriteLine(celularTres.Modelo);
            celularUno.LLamar("1111");
            celularDos.LLamar("1111");


            celularUno.LLamar(agenda[0]);
            
        }
    }
}