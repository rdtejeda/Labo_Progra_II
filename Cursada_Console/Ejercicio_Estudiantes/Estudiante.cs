using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Estudiantes
{
    internal class Estudiante
    {
        /*
         * La clase Estudiante: 
         * Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
         * El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
         * El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
         * El método privado CalcularPromedio retornará el promedio de las dos notas.
         * El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos
         * siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
         * El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
         * Nombre, apellido y legajo.
         * Nota del primer y segundo parcial.
         * Promedio.
         * Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
         */

        public string apellido;
        public string legajo;
        public string nombre;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        static public Random random;
        //Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante() 
        {
           random = new Random();
        }
        public Estudiante(string apellido, string legajo, string nombre) 
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;           
        }
        public void setNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        } 
        public void setNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        public string Mostra()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.ToString();
        }
    }
}
