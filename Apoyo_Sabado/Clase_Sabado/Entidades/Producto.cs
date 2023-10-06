
using System.Text;

namespace Entidades
{
    public class Producto : Empresa
    {
        public string Nombre { get; set; }

        public Producto(string nombre, string cUIT, string razonSocial) : base(cUIT, razonSocial)
        {

            Nombre = nombre;
        }

        public string Mostrar()
        {
            return $"Producto: {Nombre}\n";
        }

        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Info());
            sb.AppendLine(Mostrar());

            return sb.ToString();
        }
    }
}
