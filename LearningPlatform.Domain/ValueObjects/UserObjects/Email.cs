using LearningPlatform.Domain.Exceptions;

namespace LearningPlatform.Domain.ValueObjects.UserObjects;

public sealed record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidEmailException("Email cannot be empty.");

        if (!value.Contains("@"))
            throw new InvalidEmailException("Email format is invalid.");

        Value = value;
    }

    public override string ToString() => Value;
}
