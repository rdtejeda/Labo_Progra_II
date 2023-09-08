using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Celulares
{
    public class Celularess
    {
        #region Atributos
        private EMarca miMarca;
        private string modelo; //atributo privado con _bajo para diefrenciar de Propiedad
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private List<string> apps;
        private List<string> agenda;
        #endregion

        #region Constructores
        public Celularess()
        {
            apps = new List<string>();
            agenda = new List<string>();
        }

        public Celularess(EMarca miMarca, string modelo, int ram, double almacenamiento, bool encendido) : this()
        {
            this.miMarca = miMarca;
            this.modelo = modelo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.encendido = encendido;
        }

        public Celularess(EMarca miMarca, string modelo, int ram, double almacenamiento, bool encendido, List<string> agenda) : this(miMarca, modelo, ram, almacenamiento, encendido)
        {
            this.agenda = agenda;
        }
        #endregion

        public string AlternandoEncendido()
        {
            this.encendido = !this.encendido;
            return this.encendido ? "Encendiendo.." : "Apagando...";//si es verda la primera siino la segunad
            //  string retorno;
            //if(this.encendido == true)
            //{
            //    this.encendido = false;
            //    retorno = "Apagando...";
            //}
            //else
            //{
            //    this.encendido=true;
            //    retorno = "Encendiendo..";
            //}
            //return retorno;
        }
        #region Propiedades
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
            //get
            //{
            //    return this.modelo;
            //}
            //set
            //{
            //    this.modelo= value;
            //}
        }
        #endregion
        public void LLamar(string numero)
        {
            //Encendido
            if (this.encendido && BuscarEnAgenda(numero))/// separa y esle de ambos if
            {
                Console.WriteLine($"Llamando al numero: {numero}");
            }
            else
            {
                Console.WriteLine("Apagado o no esta en al agenda");
            }
            //Debe estar agendado
        }
        #region SobrecargaMetodos
        public void LLamar(Contacto unContacto)
        {
            //Encendido
            if (this.encendido && BuscarEnAgenda(unContacto.numero))/// separa y esle de ambos if
            {
                Console.WriteLine($"Llamando al numero: {unContacto.numero}");
            }
            else
            {
                Console.WriteLine("Apagado o no esta en al agenda");
            }
            //Debe estar agendado
        }
        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool respuesta = false;
            foreach (string numero in this.agenda)
            {
                if (numero == numeroIngresado)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        #endregion
        #region Sobrecarga de operadorse
        public bool InstalarApp(Apps app)
        {
            bool respuesta = false;
            //encendido
            //appa no este
            //hay especio
            return respuesta;

        }

        private bool VerificarEspacio(double nuevoSize)
        {
            //bool respuesta = false;

            //return respuesta;
            return (this.almacenamientoActual + nuevoSize) < this.almacenamiento;

        }

        public static bool operator ==(Celularess unCelular, Apps unaApp)
        {
            bool resultado = false;
            foreach (string aplicaciopn in unCelular.apps)
            {
                if (aplicaciopn == unaApp.nombre)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        public static bool operator !=(Celularess unCelular, Apps unaApp)
        {

            return !(unCelular == unaApp);
        }
        public static bool operator +(Celularess unCelu, Apps unaApp)
            {
            return false; 
            }


        #endregion
        public override string ToString()
        {
            return this.ToString(); 
        }

    }
}