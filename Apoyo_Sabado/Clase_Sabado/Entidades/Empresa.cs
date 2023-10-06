
namespace Entidades
{
    public abstract class Empresa
    {
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }

        protected Empresa(string cUIT, string razonSocial)
        {
            CUIT = cUIT;
            RazonSocial = razonSocial;
        }

        public virtual string Info()
        {
            return $"Empresa: {RazonSocial} - CUIT: {CUIT}";
        }
    }
}
