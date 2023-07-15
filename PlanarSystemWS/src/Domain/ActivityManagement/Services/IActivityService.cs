namespace PlanarSystemWS.src.Domain.ActivityManagement;

public interface IActivityService
{
    void Save(Activity activity);
    Activity FindById(string id);
    void Update(Activity activity);
}