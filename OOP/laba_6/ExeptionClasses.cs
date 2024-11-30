using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    public class InvalidArgument<T> : ArgumentException
    {
        public T Value {  get; }
        public InvalidArgument(string message, T value) : base(message)
        {
            Value = value;
        }
    }

    public class InventoryDuplication : Exception
    {
        public InventoryDuplication(string message) : base(message) { }
    }
}
