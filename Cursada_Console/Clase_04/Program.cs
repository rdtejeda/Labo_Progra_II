using ClasesNegocio;

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

            Celular celularUno = new Celular(EMarca.Apple, "14",8,128);
            Celular celularDos = new Celular(EMarca.Samsung, "S23", 32, 256);
            Celular celularTres = new Celular();

           celularTres.Modelo=" celulJAJJAJAS20";
            Console.WriteLine(celularTres.Modelo);
            //celularDos.Agenda = agenda;
            celularUno.Llamar("1111");
            celularDos.AlternandoEncendido();
            celularDos.Llamar("1111");
            LLamada nuevaLlamada = new LLamada("1111",DateTime.Now);
            celularDos.ListaLlamadas.Add(nuevaLlamada);
            nuevaLlamada.CalculaDuracionLlamada(DateTime.Now,DateTime.Now);
            nuevaLlamada.ToString();

            celularUno.Llamar(agenda[0]);

            Console.WriteLine("****************************************");
            Celular celular1 = new Celular(EMarca.Samsung, "J7", 400, 640);
            celular1.AlternandoEncendido();
            App app1 = new App("Tinder", 40f);
            App app2 = new App("WhatsApp", 20f);
            App app3 = new App("Instagram", 15f);

            List<App> listaApps = new List<App>();
            listaApps.Add(app1);
            listaApps.Add(app2);
            listaApps.Add(app3);
            bool exito;
            foreach (App aplicacion in listaApps)
            {
                exito = celular1 + aplicacion;
                if (exito)
                {
                    Console.WriteLine($"Exito al instalar {aplicacion.Nombre}");
                }
                else
                {
                    Console.WriteLine($"No se pudo instalar {aplicacion.Nombre} por falta de memoria");

                }
            }

            Console.WriteLine(celular1.ToString());


        }
    }
}