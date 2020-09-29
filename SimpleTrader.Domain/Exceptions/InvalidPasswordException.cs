using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleTrader.Domain.Exceptions
{
    public class InvalidPasswordException : Exception
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public InvalidPasswordException(string message, string userName, string userPassword) : base(message)
        {
            Username = userName;
            Password = userPassword;
        }

        public InvalidPasswordException(string message, Exception innerException, string userName, string userPassword) : base(message, innerException)
        {
            Username = userName;
            Password = userPassword;
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context, string userName, string userPassword) : base(info, context)
        {
            Username = userName;
            Password = userPassword;
        }

        public InvalidPasswordException(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
