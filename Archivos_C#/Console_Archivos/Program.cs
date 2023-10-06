using System;
using System.IO; //direc
using System.Text.Json;
using Clases;
using System.Xml.Serialization;
using Manejador_Archivo;
using System.ComponentModel;
using System.Diagnostics;

namespace Console_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = @"\MisEmpleados.xml";
            //string nombreJSON= 
            string path = ruta + nombre;

            Administrativo administrativo = new Administrativo(false, 4, "Pepe", 13);
            Cadete cadete = new Cadete("Luis", 6F, true);
            Administrativo administrativo1 = new Administrativo(false, 40, "Luis", 10);
            Cadete cadete1 = new Cadete("Andrea", 4F, false);
            Empleado emple = new Cadete("luisa", 567, true);// al definbirla como abstracta no se `puede instanciar

            List<Empleado> listEmpl = new List<Empleado>();
            listEmpl.Add(cadete);
            listEmpl.Add(administrativo);
            listEmpl.Add(cadete1);
            listEmpl.Add(administrativo1);
            listEmpl.Add(emple);

            try
            {
                Serializadora.EscririJSON(ruta + @"\EmplJSON", listEmpl);
                //Serializadora.EscribirXML(@".\MisEmpleados.xml", listEmpl);
                Serializadora.EscribirXML(path, listEmpl);
                ///para persister la jerarquia debemos decirle que hay herencia
                //listEmpl = Serializadora.LeerXML(path);
                Serializadora.EscribirXML(ruta + @"\MisEmpleados_New.xml", Serializadora.LeerXML(path));

                foreach (var emppleado in listEmpl)
                {
                    Console.WriteLine(emppleado.ToString());
                }
                Console.WriteLine(" =================");
                listEmpl = Serializadora.LeerJson(ruta + @"\EmplJSON");
                foreach (var emppleado in listEmpl)
                {
                    Console.WriteLine(emppleado.ToString());
                }
                Serializadora.EscririJSON(ruta + @"\EmplJSON_New", listEmpl);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw ;
            }

            /*
            // URL del sitio web que deseas abrir en el navegador
            string url = @"C:\Program Files\Google\Chrome\Application\chrome.exe";// "https://www.google.com";
            // Abre el navegador web predeterminado con la URL
            AbrirNavegadorWeb(url);
            static void AbrirNavegadorWeb(string url)
            {
                try
                {
                    // Utiliza Process.Start para abrir el navegador web predeterminado con la URL proporcionada
                    Process.Start(url);                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al abrir el navegador web: {ex.Message}");
                }
            }
            //Console.ReadKey();
            */
        }
    }
}