using System;
using System.IO; //direc
using System.Text.Json;
using Clases;
using System.Xml.Serialization;
using Manejador_Archivo;
using System.ComponentModel;

namespace Console_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = @"\MisEmpleados.xml";
           // string nombreJSON= 
            string path = ruta+nombre;

            Administrativo administrativo = new Administrativo(false, 4, "Pepe", 13);
            Cadete cadete = new Cadete("Luis", 6F, true);
            Administrativo administrativo1 = new Administrativo(false, 40, "Luis", 10);
            Cadete cadete1 = new Cadete("Andrea", 4F, false);
            //Empleado emple = new Empleado("luisa", 567f); al definbirla como abstracta no se `puede instanciar

            List<Empleado> listEmpl= new List<Empleado>();
            listEmpl.Add(cadete);
            listEmpl.Add(administrativo);
            listEmpl.Add(cadete1);
            listEmpl.Add(administrativo1);
          //listEmpl.Add(emple);
           

            try
            {
                Serializadora.EscririJSON(ruta+@"\EmplJSON", listEmpl);
                //Serializadora.EscribirXML(@".\MisEmpleados.xml", listEmpl);
                Serializadora.EscribirXML(path, listEmpl);
                ///para persister la jerarquia debemos decirle que hay herencia
                listEmpl = Serializadora.LeerXML(path);
                foreach (var emppleado in listEmpl)
                {
                    Console.WriteLine(emppleado.ToString());
                }
                Console.WriteLine(  "=================");
                listEmpl = Serializadora.LeerJson(ruta + @"\EmplJSON");
                foreach (var emppleado in listEmpl)
                {
                    Console.WriteLine(emppleado.ToString());
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.ToString());
                //throw ;
            }



            /*
            * Se maneja con la rura C:\loquesea\laruta\archivo.txt
            * es una m,anera de ordnar los archivpos en coleciones
            * C:\Users\rober\Documents\GitHub\Labo_Progra_II\Archivos_C# ABSOLUTA
            * RELATIVA DEPENDE DE DONDE ESTOA .\donde estamos  ..\un directio para atras 
            */
            //string directorioActual = Directory.GetCurrentDirectory();
            //Console.WriteLine(directorioActual); //directorio donde esta la app
            //Directory.CreateDirectory(@"C: \Users\rober\Documents\GitHub\Labo_Progra_II\Archivos_C#\Console_Archivos\bin\Debug\net6.0\nuevoDirectorio");
            //Directory.CreateDirectory(@".\nuevoDirectorio");
            // el @ verbatin lo interpreta como un caracter y no como barra de escape como el $

            //Directory.Move(directorioActual, Path.Combine());//ver de verificar existencai
            //Directory.Exists("path");//bool para decision
            // close y dispose si lo haces a mano poe¡rque no se limpia

            //CLASE FILE

            //StreamWriter streamWriter = new StreamWriter(@".\archivo StrteaWriter.txt");
            //streamWriter.WriteLine("Otro hola mundo");// abre y graba baja linea
            //streamWriter.Write(" MMMMASASSSSAA");// no parsa linea
            //streamWriter.Write(" MMMMENOOOS");
            //streamWriter.Close();//cierra
            //streamWriter.Dispose();//dispone
            //streamWriter.

            //File.WriteAllText(@".\archivo.txt","Hola Mundo ");
            //StreamReader streamReader = new StreamReader(@".\archivo StrteaWriter.txt");

            //string leido = streamReader.ReadToEnd();
            //string leido0 = streamReader.ReadLine();
           
            //Console.WriteLine(leido0);
            //Console.WriteLine(leido);
            //streamReader.Close();
            //streamReader.Dispose();

            //using( StreamReader otrosSR = new StreamReader(@".\archivo StrteaWriter.txt")) //al salir del scope se muere todo
            //{
            //    string leido = otrosSR.ReadToEnd();
            //    string leido0 = otrosSR.ReadLine();

            //    Console.WriteLine(leido0);
            //    Console.WriteLine(leido);
            //    otrosSR.Close();
            //    otrosSR.Dispose();
            //    //no necesito destruir ni disponer
            //}
            // SEREALIZAR OBJETOS
            // persistencia...Cominucacio..ala arch y bad
            //propiedades publicas se serealizan
            ///JSON
            ///

            ///XML constructor sin parametros


        }
    }
}