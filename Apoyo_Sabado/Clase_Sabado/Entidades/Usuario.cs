namespace Entidades
{
    public abstract class Usuario
    {
        protected string Cuenta { get; set; }
        protected string Clave { get; set; }

        public abstract string Mostrar();
    }
}