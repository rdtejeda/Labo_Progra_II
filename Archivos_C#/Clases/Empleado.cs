using System.Xml.Serialization;

namespace Clases
{
    [Serializable]//se puedd
    [XmlInclude(typeof(Cadete))]
    [XmlInclude(typeof(Administrativo))]
    public class Empleado
    //public abstract class Empleado
    {
        
        protected string nombre;
        protected float salario;
        public Empleado()
        {
            
        }
        public Empleado(string nombre, float salario) 
        {
            this.Nombre = nombre;
            this.Salario = salario;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return $"{Nombre} --- {Salario}";
        }

    }
}