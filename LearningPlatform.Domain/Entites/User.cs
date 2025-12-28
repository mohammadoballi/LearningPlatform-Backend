using System;
using System.Collections.Generic;
using System.Text;
using LearningPlatform.Domain.ValueObjects.UserObjects;

namespace LearningPlatform.Domain.Entities;

public sealed class User
{
    public Guid Id { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber Phone { get; private set; }
    public FullName FullName { get; private set; }
    public bool IsActive { get; private set; }

    private User() { } 
    public User(FullName fullName, Email email, PhoneNumber phone)
    {
        Id = Guid.NewGuid();
        Email = email;
        FullName = fullName;
        IsActive = true;
        Phone = phone;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void ChangeEmail(Email newEmail)
    {
        if (!IsActive)
            throw new Exceptions.UserExceptions.UserInactiveException("Cannot change email of an inactive user.");

        Email = newEmail;
    }

    public void ChangePhoneNumber(PhoneNumber newPhone)
    {
        if (!IsActive)
            throw new Exceptions.UserExceptions.UserInactiveException("Cannot change phone number of an inactive user.");

        Phone = newPhone;
    }

    public void ChangeFullName(FullName newFullName)
    {
        if (!IsActive)
            throw new Exceptions.UserExceptions.UserInactiveException("Cannot change full name of an inactive user.");

        FullName = newFullName;
    }
}
