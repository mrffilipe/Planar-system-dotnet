namespace PlanarAuthenticationWS.src.Application;

public interface IAuthenticationAdapter
{
    Task<SignInUserResultDTO> SignIn(SignInUserDTO user);
}