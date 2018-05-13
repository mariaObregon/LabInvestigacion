using System;

namespace Negocio
{

    [Serializable]
    public class ExcepcionExisteID : Exception
    {
        public ExcepcionExisteID() : base("El ID ingresado ya existe") { }
        public ExcepcionExisteID(string message) : base(message) { }
        public ExcepcionExisteID(string message, Exception inner) : base(message, inner) { }
        protected ExcepcionExisteID(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
    }

