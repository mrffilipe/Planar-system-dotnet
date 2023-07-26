using Newtonsoft.Json;
using System.Text;

namespace PlanarActivityWS.src.Domain;

public abstract class BaseEvent : IEvent
{
    public abstract string Queue { get; protected set; }
    public abstract string Exchange { get; protected set; }
    public abstract string RoutingKey { get; protected set; }

    public Byte[] GetSerializationBytes()
    {
        var serialize = JsonConvert.SerializeObject(this);
        var bytes = Encoding.UTF8.GetBytes(serialize);

        return bytes;
    }
}