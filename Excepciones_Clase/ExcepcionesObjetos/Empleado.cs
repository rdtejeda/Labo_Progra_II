using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesObjetos
{
    public class Empleado
    {
        private int _id;
        private string _nombre;
        private float _sueldo;
        public Empleado(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;            
        }
        public int Id { get => _id;  }
        public string Nombre { get => _nombre; }
        public float Sueldo 
        { 
            get
            {
                return this._sueldo;
            }                
            set
            {
                float auxSueldo;
                auxSueldo = value-value*0.1F;
                if (auxSueldo <=  500000)
                {
                    this._sueldo = value;
                }
                else
                {
                    throw new SobreSueldoException("Ud con los descuento seria demasiadop rico", auxSueldo);
                }                
            }            
        }
        public void Mostar()
        {
            Console.WriteLine($"{_id } - {_nombre} - {_sueldo}");
        } 
    }
}
