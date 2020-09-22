using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Exceptions
{
    class InsufficientFundsException : Exception
    {

        public double AccountBalance { get; set; }
        public double RequiredBalance { get; set; }
        public InsufficientFundsException(double AccountBalance, double RequiredBalance)
        {
            this.AccountBalance = AccountBalance;
            this.RequiredBalance = RequiredBalance;
        }

        public InsufficientFundsException(string message, double AccountBalance, double RequiredBalance) : base(message)
        {
            this.AccountBalance = AccountBalance;
            this.RequiredBalance = RequiredBalance;
        }

        public InsufficientFundsException(string message, Exception innerException, double AccountBalance, double RequiredBalance) : base(message, innerException)
        {
            this.AccountBalance = AccountBalance;
            this.RequiredBalance = RequiredBalance;
        }

        protected InsufficientFundsException(SerializationInfo info, StreamingContext context, double AccountBalance, double RequiredBalance) : base(info, context)
        {
            this.AccountBalance = AccountBalance;
            this.RequiredBalance = RequiredBalance;
        }
    }
}
