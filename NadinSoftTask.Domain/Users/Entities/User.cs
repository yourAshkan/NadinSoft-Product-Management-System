﻿using Microsoft.AspNetCore.Identity;

namespace NadinSoftTask.Domain.Users.Entities;

public class User : IdentityUser<int>
{
    public User()
    {
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string? EmailAddress { get; set; }
}
