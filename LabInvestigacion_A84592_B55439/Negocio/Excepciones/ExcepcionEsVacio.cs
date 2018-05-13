using System;

namespace Negocio
{

    [Serializable]
    public class ExcepcionEsVacio : Exception
    {
        public ExcepcionEsVacio() : base("Hay campos vacios") { }
        public ExcepcionEsVacio(string message) : base(message) { }
        public ExcepcionEsVacio(string message, Exception inner) : base(message, inner) { }
        protected ExcepcionEsVacio(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
