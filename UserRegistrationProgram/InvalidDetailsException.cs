using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class InvalidDetailsException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIRSTNAME_INVALID, LASTNAME_INVALID, MOBILENUMBER_INVALID, PASSWORD_INVALID, EMAILID_INVALID
        }
        public InvalidDetailsException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
