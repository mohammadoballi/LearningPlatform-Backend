using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.Exceptions.UserExceptions
{
    public class InvalidFullNameExceptionException : Exception
    {
        public InvalidFullNameExceptionException(string message) : base(message)
        {
        }
    
    }
}
