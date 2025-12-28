using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.Exceptions.UserExceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message)
        {
        }
    
    }
}
