﻿using System;

namespace CSharpHomeCase6_1.MyExceptions
{
    [Serializable]
    public class NotEqualSidesException : ApplicationException
    {
        public NotEqualSidesException() { }
        public NotEqualSidesException(string message) : base(message) { }
        public NotEqualSidesException(string message, Exception inner) : base(message, inner) { }
        protected NotEqualSidesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
