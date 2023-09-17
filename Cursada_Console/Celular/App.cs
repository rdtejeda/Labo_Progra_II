using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class App
    {
        private string nombre;
        private double size;
        public App()
        {

        }
        public App(string nombre, double size)
        {
            this.Nombre = nombre;
            this.Size = size;
        }
        public string Nombre { get=>nombre; set=>nombre=value; }
        public double Size { get=>size; set=>size=value; }
        public string MostrarApp(App laApp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre de la aplicacion: {this.nombre}");
            sb.Append($"Tamaño de la aplicaciopn: {this.size} megas");
            return sb.ToString();
        }
        // Sobrecarga del operador explícito para convertir App a string
        public static explicit operator string(App laApp)
        {
            return $"{laApp.Nombre} ({laApp.Size} GB)";
        }

        // Sobrecarga del operador explícito para convertir App a double
        public static implicit operator double(App laApp)
        {
            return laApp.Size;
        }

    }

}
