using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messenger;

public class MessengerEndPoint : IAdressee
{

    private Messenger _messenger;

    public MessengerEndPoint(Messenger messenger)
    {
        _messenger = messenger;
    }

    public void MessageSending(Message.Message message)
    {
        if (message != null) _messenger.ShowText(message.MainBody);
    }
}