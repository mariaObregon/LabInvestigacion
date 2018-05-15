using System;

namespace Negocio
{

    [Serializable]
    public class ExcepcionLimiteInventario : Exception
    {
        public ExcepcionLimiteInventario()  { }
        public ExcepcionLimiteInventario(string message) : base(message) { }
        public ExcepcionLimiteInventario(string message, Exception inner) : base(message, inner) { }
        protected ExcepcionLimiteInventario(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
