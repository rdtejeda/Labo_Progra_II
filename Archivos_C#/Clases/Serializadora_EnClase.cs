using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public static class Serializadora_EnClase
    {
        /*
        * Se maneja con la rura C:\loquesea\laruta\archivo.txt
        * es una m,anera de ordnar los archivpos en coleciones
        * C:\Users\rober\Documents\GitHub\Labo_Progra_II\Archivos_C# ABSOLUTA
        * RELATIVA DEPENDE DE DONDE ESTOA .\donde estamos  ..\un directio para atras 
        */
        public static void Todo()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            Console.WriteLine(directorioActual); //directorio donde esta la app
            Directory.CreateDirectory(@"C: \Users\rober\Documents\GitHub\Labo_Progra_II\Archivos_C#\Console_Archivos\bin\Debug\net6.0\nuevoDirectorio");
            Directory.CreateDirectory(@".\nuevoDirectorio");
            //el @ verbatin lo interpreta como un caracter y no como barra de escape como el $

            Directory.Move(directorioActual, Path.Combine());//ver de verificar existencai
            Directory.Exists("path");//bool para decision
            //close y dispose si lo haces a mano poe¡rque no se limpia

            //CLASE FILE

            StreamWriter streamWriter = new StreamWriter(@".\archivo StrteaWriter.txt");
            streamWriter.WriteLine("Otro hola mundo");// abre y graba baja linea
            streamWriter.Write(" MMMMASASSSSAA");// no parsa linea
            streamWriter.Write(" MMMMENOOOS");
            streamWriter.Close();//cierra
            streamWriter.Dispose();//dispone
            //streamWriter.File.WriteAllText(@".\archivo.txt", "Hola Mundo ");
            StreamReader streamReader = new StreamReader(@".\archivo StrteaWriter.txt");

            string leido = streamReader.ReadToEnd();
            string leido0 = streamReader.ReadLine();

            Console.WriteLine(leido0);
            Console.WriteLine(leido);
            streamReader.Close();
            streamReader.Dispose();

            using (StreamReader otrosSR = new StreamReader(@".\archivo StrteaWriter.txt")) //al salir del scope se muere todo
            {
                string leido00 = otrosSR.ReadToEnd();
                string leido0001 = otrosSR.ReadLine();

                Console.WriteLine(leido00);
                Console.WriteLine(leido0001);
                otrosSR.Close();
                otrosSR.Dispose();
                //no necesito destruir ni disponer
            }
            //SEREALIZAR OBJETOS
            //persistencia...Cominucacio..ala arch y bad
            //propiedades publicas se serealizan
            //JSON
            //XML constructor sin parametros
        }
    }
}
