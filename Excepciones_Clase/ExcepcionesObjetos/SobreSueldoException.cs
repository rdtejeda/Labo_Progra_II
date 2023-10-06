using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesObjetos
{
   public class SobreSueldoException : Exception
   {
        float _sobreSueldo;
        public SobreSueldoException(string mensaje, float sobreSueldo):base(mensaje)
        {
                this._sobreSueldo = sobreSueldo;
        }
        public float SobreSueldo 
        {
            get
            {
                return this._sobreSueldo;
            }
            set => _sobreSueldo = value; 
        }
    }
}
