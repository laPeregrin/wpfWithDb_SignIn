using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleTrader.Domain.Exceptions
{
    class InvalidPasswordException : Exception
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public InvalidPasswordException(string message, string userName, string userPassword) : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception innerException, string userName, string userPassword) : base(message, innerException)
        {
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context, string userName, string userPassword) : base(info, context)
        {
        }

        public InvalidPasswordException(string username, string password, string userName, string userPassword)
        {
            Username = username;
            Password = password;
        }
    }
}
