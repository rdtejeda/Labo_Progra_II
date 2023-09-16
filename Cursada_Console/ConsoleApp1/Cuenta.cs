using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cuenta
    {
        /*
         * Deberá tener los atributos:
         * titular: que contendrá la razón social del titular de la cuenta.
         * cantidad:  que será un número decimal que representa al monto actual de dinero en la cuenta.
         */
        public string titular;
        public float cantidad;
        /*
         * Construir los siguientes métodos para la clase:
         * Un constructor que permita inicializar todos los atributos.
         * Un método getter para cada atributo.
         * CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
         * IngresarDinero: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
         * RetirarDinero: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo. 
         */
        public Cuenta(string nombreTitular, float cantidadInicial)
        {
            this.titular = nombreTitular;
            this.cantidad = cantidadInicial;
        }
        public string getTitular()
        { 
            return this.titular;
        }
        public float getCantidad()
        {  
            return this.cantidad;
        }    
        public string CuentaToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Titular de la cuenta: {this.getTitular()}");
            retorno.AppendLine($"Monto de la cuata: {this.getCantidad()}");
            return retorno.ToString();
        }
        public void IngresarDinero(float montoIngresado)
        {
            if( montoIngresado > 0 )
            {
                this.cantidad += montoIngresado;
            }
        }
        public void RetirarDinero(float montoRetirar)
        {
            this.cantidad -= montoRetirar;
        }
    }
}
