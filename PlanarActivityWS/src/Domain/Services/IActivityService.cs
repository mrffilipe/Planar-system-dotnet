namespace PlanarActivityWS.src.Domain;

public interface IActivityService
{
    void Save(Activity activity);
    Activity FindById(string id);
    void Update(Activity activity);
}