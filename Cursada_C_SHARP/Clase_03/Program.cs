namespace Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ver atributo estatico: {Celular.sitemaOperativo}");
            //crear instancia de objeto (direccion de memoria heap en la pila)
            Celular miCelular; //crea objeto en el heap puntero a variable
            miCelular = new Celular(); //new crea espacio en memoria en pila asigancion de memoria dinamica
            Celular.sitemaOperativo = "Windows"; //le cabio el valor del atributo a toda la clase
            //miCelular.modelo = "S23";
            //Console.WriteLine(miCelular.modelo);
            Celular otroCelular = new Celular("S21",true); //dos etapas en una creo y reservo ojota que no es lo mismo
            Console.WriteLine($"Modelo: {miCelular.modelo} - Estado {miCelular.getEstaEncendido} - SO: {Celular.sitemaOperativo}"); //cuando haya geter de cada instancia asi de toda la clase
            Console.WriteLine($"Modelo: {otroCelular.modelo} - Estado {otroCelular.getEstaEncendido}");
            miCelular.setEstaEncendido(true);
            //OBJETO ES UNA INSTANCIA HECHA CON EL MOLDE QUE ES LA CLASE El obleto vivie en el heap y se definen en tiempo de ejecucion
            //la craecion de on objeto es deterministayo loc reo y eso se hace cuando resreferncio
            //cuando la variable al objeto con NULL no el objeto de la pila exciste hat que el GC lo elimina es nodeterminista
            miCelular.Llamar("23982400");
        }
    }
}