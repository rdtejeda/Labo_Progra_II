using System.Threading.Channels;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Primer Ejemplo

            /*
             * Es una forma de manejar un error en tiempo de ejecucion
             * y que no se rompa o crashea
             * exceptio es un objeto

             * catch => atrapar
             * Puerdo o no mostrar el resultado del error depende de lo que este programando
             */

            /*
            int a;
            int b;
            int c;
            List<int> list = new List<int>();
            //try
            //{
            //    list.Add(1);
            //    list.Add(2);
            //    list.Add(3);
            //    list = null;
            //    //GC.Collect(); no usar
            //    list.Add(4);
            //    list.Add(5);
            //    list.Add(6);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                Console.WriteLine("ingreseel divisor");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("ingreseel dividendo");
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex) //una ves que captura corta el flijo
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)//depende que quiera hacer
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)// el mas generivco de todos
            {
                Console.WriteLine("Su Excepcion es :" + ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Paso si o si");
            }
            */

            #endregion
            #region Segundo Ejemplo
            /*
			 * throw =>lanza
			 * inner => capacidad de encapsular las distintas excepciones
			*/

            /*
			try
			{
				Metodo1();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.ToString());
                Console.WriteLine("*****************");
                Console.WriteLine(ex.InnerException);
            }
			static void Metodo1()
			{
				try
				{
					Metodo2();
				}
				catch (Exception exM2)
				{
                    //Console.WriteLine("Aca la atrape en 1");
					throw new Exception("Error en 2", exM2);
                }				
			}
			static void Metodo2()//VA PARA ARRIBA HASTA QUE ALGUIEN LA CATCHEE
			{
                try
                {
                    Metodo3();
                }
                catch (Exception exM3)
                {
                   // Console.WriteLine("Aca la atrape en 21");
                    throw new Exception("Error en 2", exM3);
                }                
			}
            static void Metodo3()
            {
                throw new InvalidOperationException("eRROR EN m3");//lanzo una ex generica o una mia
            }
            */

            #endregion
            #region Tercer Ejemplo
            /*
            List<Object> list = new List<Object> { 1, 2, 3 };//,"Perro",4,5};
            List<int> list2 = new List<int>();
            try
            {
                Cargarlista(list, list2);
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                Console.WriteLine("++++++++++++");
                Console.WriteLine(ex.ObjetoError.ToString()+"intento");
            } 
            */
        #endregion
        }
        static void Cargarlista(List<Object> list, List<int> list2)
        { 
            MiExcepcion siRompe= new MiExcepcion(); 
            foreach (Object item in list)
            
                if(item is int)
                {
                        list2.Add((int)item);
                }else 
                {
                       siRompe =  new MiExcepcion("Imposible agrgar un elemento a la lista", item);
                }
                if(siRompe.ObjetoError != null)
                {
                    throw siRompe;
                }                        
        }
    }
}

