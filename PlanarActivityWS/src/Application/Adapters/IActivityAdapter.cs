namespace PlanarActivityWS.src.Application;

public interface IActivityAdapter
{
    Task<IList<ReplyActivityDTO>> FindActivities();
}