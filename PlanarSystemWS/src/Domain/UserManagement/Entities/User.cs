﻿using PlanarSystemWS.src.Domain.SalesManagement;
using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.UserManagement;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public Seller? Seller { get; private set; }

    private User()
    {
    }

    public User(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }
}