using Newtonsoft.Json;
using System.Text;

namespace PlanarSystemWS.src.Domain.Shared;

public abstract class BaseEvent : IEvent
{
    public abstract string Queue { get; protected set; }
    public abstract string Exchange { get; protected set; }
    public abstract string RoutingKey { get; protected set; }

    public Byte[] GetSerializationBytes(object value)
    {
        var serialize = JsonConvert.SerializeObject(value);
        var bytes = Encoding.UTF8.GetBytes(serialize);

        return bytes;
    }
}