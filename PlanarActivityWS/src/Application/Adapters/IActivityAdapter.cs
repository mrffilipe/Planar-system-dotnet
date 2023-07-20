namespace PlanarActivityWS.src.Application;

public interface IActivityAdapter
{
    Task SaveActivity(ActivityRegistrationDTO activity);
    Task<ICollection<ReplyActivityDTO>> FindActivities();
    Task UpdateActivity(ActivityRegistrationDTO activity);
    Task SaveUser(UserRegistrationDTO user);
    Task UpdateUser(UserRegistrationDTO user);
}