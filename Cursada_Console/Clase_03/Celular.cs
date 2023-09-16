using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    internal class Celular
    {
        /*
         * scope de la clase {}
         * Constructor : Iniciliza los valorees de una clase pòr defecto o con parametreos
         * Constructo mismo nobre de la clase, recibe parametros ys e los asigna a los atributos
         * this ==> instancia actual enmemoria, el que estoy trabajando
         * Constructo estatico se ejecuta solo cuando llamo ala clase, sin parametros
         * static Celular(){ porcentajeIVA = 0.21;}
         */
        //atributos
        bool estaEncendido; //por defecto los atributos son privados
        public string modelo;
        public static string sitemaOperativo; //todos el mismo SO
        //Toda clase imlicitamente tiene un constructor
        static Celular()
        {
            //lo estatico solo ve lo estatico
            sitemaOperativo = "Android 2.5";
        }
        public Celular() 
        {
            //objeto strin null int 0 float 0,0 bool false //sobrecarga del constructor por defecto
        }

        public Celular(string modelo, bool estaEncendido) 
        {
            this.modelo = modelo;
            this.estaEncendido = estaEncendido;
        }
        //visibilidad
        /*
         * publico desde cialñquier clase o pryecto reelacionad
         * privado desde la clase donde se difinio scope
         * protejido es privado salvo en la herencia clase o derivadas se ven
         * interno es publco pero dentro del mismo proyecto encapsulado del proyecto
         */
        //Metodos de acceso cosulto o modifico atributos sin rompoer el encapsulamiento
        //prertis
        public bool getEstaEncendido() { return this.estaEncendido; }
        public string getModelo() { return modelo;}//asi funcioan
        public void setModelo(string modelo)
        {
            this.modelo = modelo; 
        }
        public void setEstaEncendido(bool esta)
        {
            this.estaEncendido= esta;
        }
        //parte dinamica de la clase genertalmente publico
        public void Llamar(string numero)
        {
            if(numero != null) { }
            Console.WriteLine($"Estoy llamando a: {numero}");
        }
        public static void Mostrar()
        {
            Console.WriteLine("Te muestyro");
        }


    }
}
