using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class MiExcepcion : Exception
    {
        Object objetoError;

        public MiExcepcion()
        {
        }

        public MiExcepcion(string mensaje, Object objetoError):base(mensaje)
        {
            ObjetoError = objetoError;
        }

        public object ObjetoError { get => objetoError; set => objetoError = value; }
    }
}
