using PlanarSystemWS.src.Domain.shared;

namespace PlanarSystemWS.src.Domain.ChatMessaging;

public class Message : BaseEntity
{
    public Participant Participant { get; private set; }
    public string Text { get; private set; }
    public bool Read { get; private set; }
    public DateTime DateRead { get; private set; }

    public Message(Participant participant, string text, bool read, DateTime dateRead)
    {
        Participant = participant;
        Text = text;
        Read = read;
        DateRead = dateRead;
    }

    public void ConfirmRead()
    {
        if (!Read)
        {
            Read = true;
            ChangeDateRead();
        }
    }

    private void ChangeDateRead()
    {
        DateRead = DateTime.UtcNow;
    }
}