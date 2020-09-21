using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidSymbolException : Exception
    {
        public string Symbol { get; set; }

        public InvalidSymbolException(string symbol)
        {
            this.Symbol = symbol;
        }

        public InvalidSymbolException(string symbol, string message, Exception innerException) : base(message, innerException)
        {
            this.Symbol = symbol;
        }

        protected InvalidSymbolException(string symbol, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Symbol = symbol;
        }
    }
}
