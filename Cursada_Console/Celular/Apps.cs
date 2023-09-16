using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celulares
{
    public class Apps
    {
        private string nombre;
        private int size;

        public Apps(string nombre, int size)
        {
            this.Nombre = nombre;
            this.Size = size;
        }
        public string Nombre { get=>nombre; set=>nombre=value; }
        public int Size { get=>size; set=>size=value; }
        public string MostrarApp(Apps laApp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre de la aplicacion: {this.nombre}");
            sb.Append($"Tamaño de la aplicaciopn: {this.size} megas");
            return sb.ToString();
        }
        // Sobrecarga del operador explícito para convertir App a string
        public static explicit operator string(Apps laApp)
        {
            return $"{laApp.Nombre} ({laApp.Size} GB)";
        }

        // Sobrecarga del operador explícito para convertir App a double
        public static implicit operator double(Apps laApp)
        {
            return laApp.Size;
        }

    }

}
