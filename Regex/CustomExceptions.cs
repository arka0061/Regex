using System;
using System.Collections.Generic;
using System.Text;

namespace RegexValidation
{
    public class CustomExceptions:Exception
    {
        public readonly ExceptionType type;
        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_PHNO, INVALID_PASSWORD, INVALID_EMAIL
        }
      
    }
}
