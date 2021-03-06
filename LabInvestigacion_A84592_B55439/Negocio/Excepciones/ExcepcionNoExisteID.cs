﻿using System;

namespace Negocio
{

    [Serializable]
    public class ExcepcionNoExisteID : Exception
    {
        public ExcepcionNoExisteID() : base("El ID ingresado no existe") { }
        public ExcepcionNoExisteID(string message) : base(message) { }
        public ExcepcionNoExisteID(string message, Exception inner) : base(message, inner) { }
        protected ExcepcionNoExisteID(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
