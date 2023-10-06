namespace ExcepcionesObjetos
{
    internal class ProgramObj
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1,"Josefina");
            empleado1.Sueldo = 1000000000;
            try
            {
                empleado1.Sueldo = 1000000000;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }           
        }
    }
}