using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.ChatMessaging;

public class Conversation : BaseEntity
{
    public Participant Participant1 { get; private set; }
    public Participant Participant2 { get; private set; }
    public ICollection<Message> Messages { get; private set; }

    public Conversation(Participant participant1, Participant participant2, ICollection<Message> messages)
    {
        Participant1 = participant1;
        Participant2 = participant2;
        Messages = messages;
    }
}