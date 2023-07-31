using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PlanarAuthenticationWS.src.Domain;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PlanarAuthenticationWS.src.Application;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<CustomIdentityUser> _userManager;
    private readonly IMapper _mapper;

    public AuthenticationService(
        UserManager<CustomIdentityUser> userManager,
        IMapper mapper
        )
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<IdentityResult> RegisterUser(User user)
    {
        try
        {
            var userMap = _mapper.Map<CustomIdentityUser>(user);

            //var result = await _userManager.CreateAsync(userMap);
            var result = await _userManager.CreateAsync(userMap, "Teste@123");

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<SignInUserResult> SignIn(SignInUser user)
    {
        try
        {
            var userResult = await _userManager.FindByNameAsync(user.UserName);

            if (userResult != null)
            {
                if (await _userManager.CheckPasswordAsync(userResult, user.Password))
                {
                    var result = new SignInUserResult(
                        userResult.UserName,
                        GenerateToken(userResult)
                        );

                    return result;
                }
            }

            throw new Exception(); // verificar 
        }
        catch (Exception ex) { throw; }
    }

    private static string GenerateToken(CustomIdentityUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim (ClaimTypes.Name, user.UserName),
                //new Claim (ClaimTypes.Role, "") // verificar
            }),
            Expires = DateTime.UtcNow.AddHours(2),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey
                (
                Encoding.UTF8.GetBytes("698dc19d489c4e4db73e28a713eab07b")), // verificar
                SecurityAlgorithms.HmacSha256Signature
                )
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}