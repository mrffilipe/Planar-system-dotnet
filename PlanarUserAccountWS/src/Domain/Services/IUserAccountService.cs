﻿namespace PlanarUserAccountWS.src.Domain;

public interface IUserAccountService
{
    Task RegisterUser(User user);
    Task<User> FindUserById(Guid id);
    Task<ICollection<User>> FindAllUsers();
    Task UpdateUser(User user);
    Task AddClaimToUser(RefUserClaim claim);
    Task UpdateUserClaim(RefUserClaim claim);
    Task RemoveUserClaim(RefUserClaim claim);
}