using System;

namespace CSharpHomeCase6_1.MyExceptions
{
    public class PointCoincidenceException : ApplicationException
    {
        public PointCoincidenceException() { }

        public PointCoincidenceException(string message) : base(message) { }

        public PointCoincidenceException(string message, Exception inner) : base(message, inner) { }

        protected PointCoincidenceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
