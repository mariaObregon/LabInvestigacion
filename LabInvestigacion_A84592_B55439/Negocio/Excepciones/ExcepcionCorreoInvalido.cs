using System;

namespace Negocio
{

    public class ExcepcionCorreoInvalido : Exception
    {
        public ExcepcionCorreoInvalido() : base("Formato de correo invalido") { }
        public ExcepcionCorreoInvalido(string message) : base(message) { }
        public ExcepcionCorreoInvalido(string message, Exception inner) : base(message, inner) { }
        protected ExcepcionCorreoInvalido(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    }

