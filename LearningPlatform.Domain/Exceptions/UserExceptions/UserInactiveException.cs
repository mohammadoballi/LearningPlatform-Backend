using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.Exceptions.UserExceptions
{
    public class UserInactiveException : Exception
    {
        public UserInactiveException(string message):base(message) { 
        
        } 
    }
}
