namespace PlanarSystemWS.src.Domain.ActivityManagement;

public interface IActivityRepository
{
    void Save(Activity activity);
    Activity FindById(string id);
    void Update(Activity activity);
}
