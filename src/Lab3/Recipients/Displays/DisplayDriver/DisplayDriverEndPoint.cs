namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class DisplayDriverEndPoint
{
    private DisplayDriver _displayDriver;

    public DisplayDriverEndPoint(DisplayDriver display)
    {
        _displayDriver = display;
    }

    public void MessageSending(Message.Message message)
    {
        if (message != null) _displayDriver.ShowColorText(message.MainBody);
    }
}