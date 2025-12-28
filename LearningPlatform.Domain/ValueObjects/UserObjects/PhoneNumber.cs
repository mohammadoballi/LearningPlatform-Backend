using LearningPlatform.Domain.Exceptions;
using LearningPlatform.Domain.Exceptions.UserExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Domain.ValueObjects.UserObjects
{
    public class PhoneNumber
    {
        public string Value { get; }

        public PhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidPhoneNumberException("Phone number cannot be empty.");

            if (!(value.StartsWith("+") || value.StartsWith("00")))
                throw new InvalidPhoneNumberException("Phone number Format wrnog");

            Value = value;
        }

        public override string ToString() => Value;
    }
}
