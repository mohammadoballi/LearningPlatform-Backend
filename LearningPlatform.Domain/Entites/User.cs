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
        IsActive = false;
    }

    public void ChangeEmail(Email newEmail)
    {
        Email = newEmail;
    }

    public void ChangePhoneNumber(PhoneNumber newPhone)
    {
        Phone = newPhone;
    }

    public void ChangeFullName(FullName newFullName)
    {
        FullName = newFullName;
    }
}
