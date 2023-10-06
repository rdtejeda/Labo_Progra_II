namespace Entidades
{
    //maqueta, no implementable y obliga a implementar metodos
    public abstract class Usuario   
    {
        //animal=>hacer sonido sin decir cual o como, que cada clase se arregle
        //propfull
        /*
        private string cuenta;

        public string Cuenta
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */
        //declaro atributo y propiedad simultaneamente
        protected string Cuenta { get; set; }
        protected string Clave { get; set; }
        public abstract string Mostrar();
        
    }
}