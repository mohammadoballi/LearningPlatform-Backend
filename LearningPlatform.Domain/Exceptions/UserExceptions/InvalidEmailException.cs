using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.Exceptions.UserExceptions;

public sealed class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message)
    {
    }
}
