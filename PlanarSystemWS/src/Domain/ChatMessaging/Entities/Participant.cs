using PlanarSystemWS.src.Domain.shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Domain.ChatMessaging;

public class Participant : BaseEntity
{
    public User User { get; private set; }
    public ParticipantPresence ParticipantPresence { get; private set; }

    public Participant(User user, ParticipantPresence participantPresence)
    {
        User = user;
        ParticipantPresence = participantPresence;
    }

    public void ChangePresence(ParticipantPresence participantPresence)
    {
        if (participantPresence != ParticipantPresence) ParticipantPresence = participantPresence;
    }
}