using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Display;

public class DisplayEndPoint : IAdressee
{
    private Display _display;

    public DisplayEndPoint(Display display)
    {
        _display = display;
    }

    public void MessageSending(Message.Message message)
    {
        if (message != null) _display.ShowColorText(message.MainBody);
    }
}