﻿using PlanarChatMessagingWS.src.Domain;

namespace PlanarChatMessagingWS.src.Application;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task Register(User user)
    {
        try
        {
            await _userRepository.Register(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<User> FindById(Guid id)
    {
        try
        {
            var user = await _userRepository.FindById(id);

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(User origin, User updated)
    {
        try
        {
            if (origin != null && updated != null)
            {
                await _userRepository.Update(origin, updated);
            }
        }
        catch (Exception ex) { throw; }
    }
}
