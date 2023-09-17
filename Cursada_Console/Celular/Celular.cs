using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClasesNegocio
{
    public class Celular
    {
        #region Atributos
        private EMarca miMarca;
        private string modelo; //atributo privado con _bajo para diefrenciar de Propiedad
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private List<App> apps;
        Dictionary<Contacto, DateTime> agenda;//key:valor
        private List<LLamada> listaLlamadas;
        private string titular;
        private string numero;
        #endregion

        #region Constructores
        public Celular()
        {
            this.Apps = new List<App>();
            this.Agenda = new Dictionary<Contacto, DateTime>();
            this.ListaLlamadas = new List<LLamada>();
        }
        public Celular(EMarca miMarca, string modelo, int ram, double almacenamiento) : this()
        {
            this.MiMarca = miMarca;
            this.Modelo = modelo;
            this.Ram = ram;
            this.Almacenamiento = almacenamiento;
            this.encendido = false;
            this.almacenamientoActual = 0;
        }
        #endregion

        #region Propiedades

        public string Modelo { get => this.modelo; set => this.modelo = value; }
        public int Ram { get=>ram; set => ram = value; }
        public EMarca MiMarca { get=>miMarca; set=>miMarca=value; }
        public double Almacenamiento { get=>almacenamiento; set=>almacenamiento=value; }
        public double AlamacenamientoActual { get=>almacenamientoActual; set=>almacenamientoActual=value; }
        public bool Encendido { get=>encendido; set=>encendido=value; }
        public Dictionary<Contacto, DateTime> Agenda { get=>agenda; set=>agenda=value; }
        public List<App> Apps { get=>apps; set=>apps=value; }
        public List<LLamada> ListaLlamadas { get => listaLlamadas; set => listaLlamadas = value; }

        #endregion

        #region Metodos de Instancia
        public string AlternandoEncendido()
        {
            this.encendido = !this.encendido;
            return this.encendido ? "Encendiendo.." : "Apagando...";
        }
        public void Llamar(string numero)
        {
            //Encendido
            if (this.encendido)/// separa y esle de ambos if
            {
                if (BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
                }
                else
                {
                    Console.WriteLine("Numero no encontrado...");
                }
                LLamada nuevaLlamada = new LLamada(numero, DateTime.Now);
                /*
                 * EL tiempo que dure que aun no se como ponerlo en codigo
                */
                DateTime fechaFin = new DateTime(2023, 10, 13);
                nuevaLlamada.CalculaDuracionLlamada(nuevaLlamada.FechaInicio, fechaFin);
                listaLlamadas.Add(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("Celular Apagado");
            }
            //Debe estar agendado
        }
        public void Llamar(Contacto unContacto) //sobrecarga de metodo
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(unContacto.Numero))
                {
                    Console.WriteLine($"Llamando a: {unContacto.Numero}");
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
        }
        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool respuesta = false;
            foreach (string numero in this.agenda.  )
            {
                if (numero == numeroIngresado)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
       

        public bool InstalarApp(App aplicacion)
        {
            bool respuesta = false;
            if (this.Encendido && this != aplicacion && VerificarEspacio(aplicacion.Size))
            {
                respuesta = true;
                this.Apps.Add(aplicacion);
                this.AlamacenamientoActual += aplicacion.Size;
            }
            return respuesta;

        }
        private bool VerificarEspacio(double nuevoSize)
        {

            return ((this.AlamacenamientoActual + nuevoSize) < this.Almacenamiento);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.MiMarca}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"RAM: {this.ram}");
            sb.AppendLine($"Almacenamiento: {this.Almacenamiento}");
            sb.AppendLine("Aplicaciones instaladas");
            if (this.apps.Count > 0)
            {
                foreach (string aplicacion in apps)
                {
                    sb.AppendLine($"\t{aplicacion}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }
            sb.AppendLine("*******************************************");
            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;
            foreach (string aplicacion in miCelu.Apps)
            {
                if (aplicacion == miApp.Nombre)
                {
                    exito = true;
                    break;
                }
            }

            return exito;
        }
        public static bool operator !=(Celular miCelu, App miApp)
        {
            return !(miCelu == miApp);
        }
        public static bool operator +(Celular miCelu, App miApp)
        {
            return miCelu.InstalarApp(miApp);
        }
        #endregion
    }
}