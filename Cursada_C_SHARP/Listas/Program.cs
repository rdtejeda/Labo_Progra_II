using System.Security.Cryptography.X509Certificates;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            #region Vectores
             /*
             * Derfinir vector como coleccionmas rustica, con datos especificos
             * los vectores son Arrays son unidimensionales
             * posision desde 0 en eadelñante
             */            
            int[] edades = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] edadesDos = new int[5];
            int[] edadesTres = new int[] {23,34,45,56,23};
            //Recorro uno
            //for(int i = 0; i < edades.Length; i++)
            //{
            //    Console.WriteLine(edades[i]);
            //}
            //Recorro 2
            //foreach(int i in edadesTres)
            //{
            //    Console.WriteLine(i);
            //{
            #endregion
           
            #region Matrices
             /*
             * Para matrice dos dimensiones i e j con coordenadas [i,j]
             * [,] cantidad de dsimensiosnes
             */

            int[,] matrizCero = new int[3,2];//3 fila y 2 columnas
            int[,] matriz= new int[,] { {5,9 },{8,78 },{3,74} };
            //Recorro uno
            //for (int i = 0; i < matriz.GetLength(0); i++) //0 fila 
            //{
            //    for (int j = 0; j <matriz.GetLength(1); j++) //1 columnas
            //    {
            //        Console.WriteLine($"{matriz[i,j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Listas
            //Console.BackgroundColor= ConsoleColor.Green;            
            List<int> list; //SOLO DECLARO            
            List<int> numeros = new List<int>(); //DCLARO E INSTANCIO
            numeros.Add(2);
            numeros.Add(1);
            numeros.Add(20);
            numeros.Add(34);
            numeros.Add(44);
            numeros.Add(5);
            numeros.Add(6);
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numeros[0]);
            //bool esta = numeros.Contains(4);
            //if (numeros.Contains(10))
            //{
            //    Console.WriteLine("Esta el numero");
            //}
            //else
            //{
            //    Console.WriteLine("No esta el numero");
            //}
            //int indice = numeros.IndexOf(13);//devuelve indice de la primera ocurrencia
            //Console.WriteLine(indice);
            //numeros.Remove(2);
            //numeros.Count();
            //numeros.Sort();
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            //numeros.Clear();
            #endregion

            #region Pilas#Staks
            /*
             * Se gaurdan de abajo hacia arriba y se saca de arriba hacia abajo
             * LIFO last into first output
             */
            Stack<int> pila = new Stack<int>();
            pila.Push(123);
            pila.Push(32);
            pila.Push(23);
            pila.Push(3);
            pila.Push(4);//el ultimo siempre tiene la ultima posisioc el mas grande
            
            //foreach (int item in pila)
            //{
            //    Console.WriteLine(item);                
            //}
            //int ultimo = pila.Peek();//obtengo el primer elementpo
            //Console.WriteLine(ultimo);
            //int eliminado= pila.Pop();//elimina el tope de la pila y lo duevuelve
            //List<int> eliminados = new List<int>();
            //foreach (int item in pila)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //   eliminados.Add(pila.Pop());
            //}
            //foreach (int item in pila)
            //{
            //    Console.WriteLine(item);
            //}
            //pila.Clear();//remuievo todo
            // pila.Count(); veeer


            #endregion

            #region Colas#Queue
            /*
             * FIFO
             * first input first output
             * sale priemro el que entro primero
             */
            Queue<string> colaNombres = new Queue<string>();
            //EnColar
            colaNombres.Enqueue("Pepe");
            colaNombres.Enqueue("Jorge");
            colaNombres.Enqueue("Hector");
            colaNombres.Enqueue("Tita");
            colaNombres.Enqueue("Luisa");

             //Console.WriteLine(colaNombres.Peek());

            //foreach (var item in colaNombres)
            //{
            //    Console.WriteLine(item);
            //}

            colaNombres.Dequeue();//saca y devuelkve el primero que entreo
            colaNombres.Peek();
            #endregion

            #region Diccionarios
            /*
             * Clave valor 5:99,5 o sea clave=5 Valor=99,5             
             */

            Dictionary<string, int> diccionarioPersona = new Dictionary<string, int>();//key:valor

            diccionarioPersona["Pepe"] = 56;
            diccionarioPersona["Victoria"] = 36;
            diccionarioPersona["Luisa"] = 16;
            diccionarioPersona["Roger"] = 26;

            //Console.WriteLine(diccionarioPersona["Pepe"]);

            //Console.WriteLine( diccionarioPersona.ContainsKey("Luia"));//devuelve bool

            //Console.WriteLine(diccionarioPersona.ContainsValue(36));

            //List<string> claves = new List<string>(diccionarioPersona.Keys);
            //foreach (string item in diccionarioPersona.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> valores = new List<int>(diccionarioPersona.Values);
            //foreach (int item in diccionarioPersona.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (KeyValuePair<string,int> par in diccionarioPersona)
            //{
            //    Console.WriteLine($"{par.Key} : {par.Value}");
            //    if(par.Value>27)
            //    {
            //        Console.WriteLine($"{par.Key} : {par.Value}");
            //    }
            //}
            #endregion

            
                //// Define the start and end timestamps (you can replace these with your own)
                DateTime fechaInicio  = new DateTime(2023, 9, 13, 10, 0, 0); // Replace with your start time
                DateTime fechaFinal  = new DateTime(2023, 9, 15, 15, 30, 0); // Replace with your end time

                // Calculate the time span between the two timestamps
                TimeSpan duration = fechaFinal - fechaInicio;

                // Extract and display the duration in days, hours, minutes, and seconds
                int days = duration.Days;
                int hours = duration.Hours;
                int minutes = duration.Minutes;
                int seconds = duration.Seconds;

                Console.WriteLine($"Duration: {days} days, {hours} hours, {minutes} minutes, {seconds} seconds");
            
        }
    }
}