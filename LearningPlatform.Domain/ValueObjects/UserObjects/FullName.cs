using LearningPlatform.Domain.Exceptions.UserExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.ValueObjects.UserObjects
{
    public class FullName
    {
        public string Value { get; }
        public FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidFullNameExceptionException("Full name cannot be empty.");

            if (value.Length < 3)
                throw new InvalidFullNameExceptionException("Full name must be at least 3 characters long.");
            Value = value;
        }
    }
}
