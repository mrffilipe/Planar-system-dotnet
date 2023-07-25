﻿using MongoDB.Bson;

namespace PlanarUserAccountWS.src.Domain;

public interface IUserAccountRepository
{
    Task RegisterUser(User user);
    Task<User> FindUserById(string id);
    Task<ICollection<User>> FindAllUsers();
    Task UpdateUser(User user);
}
