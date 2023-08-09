namespace PlanarAuthenticationWS.src.Domain;

public interface IEvent
{
    ICollection<EventConfiguration> Configurations { get; }
}