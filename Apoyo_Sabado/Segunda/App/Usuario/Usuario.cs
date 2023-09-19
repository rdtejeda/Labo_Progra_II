using System.Text;

namespace Biblioteca
{
    public class Usuario
    {
        public string nombre;
        public string correo;
        public string pass;
        public int codSeg;
        public string colorFavorito;
        public string sexo;
        public bool mayorDeEdad;
        public bool estudia;
        public bool trabaja;
        public DateTime fechaDeNacimiento;

        public int contadorClicker;

        public Usuario()
        {
            this.contadorClicker = 0;
        }

        public Usuario(string nombre, string correo, string pass, int codSeg, string colorFavorito, string sexo, bool mayorDeEdad, bool estudia, bool trabaja, DateTime fechaDeNacimiento) : this()
        {
            this.nombre = nombre;
            this.correo = correo;
            this.pass = pass;
            this.codSeg = codSeg;
            this.colorFavorito = colorFavorito;
            this.sexo = sexo;
            this.mayorDeEdad = mayorDeEdad;
            this.estudia = estudia;
            this.trabaja = trabaja;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public static string FormatearUsuario(Usuario u)
        {
            return $"[{u.nombre} - {DateTime.Now.ToString("dd/MM/yy hh:mm")}] RECORD CLICKER: {u.contadorClicker}";
        }

        public static bool operator +(Usuario[] usuarios, Usuario u)
        {

            if (usuarios == null) return false;

            foreach (Usuario item in usuarios)
            {
                if (item != null)
                {
                    if (item.correo == u.correo)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == null)
                {
                    usuarios[i] = u;
                    break;
                }
            }

            return true;
        } 
    }
}