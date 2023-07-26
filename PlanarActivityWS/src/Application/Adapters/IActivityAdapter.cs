namespace PlanarActivityWS.src.Application;

public interface IActivityAdapter
{
    Task<ICollection<ReplyActivityDTO>> FindActivities();
}