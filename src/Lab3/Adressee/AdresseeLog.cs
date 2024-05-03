using System;
using System.Diagnostics;

namespace Itmo.ObjectOrientedProgramming.Lab3.Adressee;

public class AdresseeLog : IAdressee
{
    public IAdressee Adressee { get; }

    public static void Logging(Message.Message message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        Console.Write("Log: " + message.Heading + " sended to adressee ");
    }
    public void MessageSending(Message.Message message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        Logging(message);
        Adressee.MessageSending(message);
    }
    
    public AdresseeLog(IAdressee adressee)
    {
        Adressee = adressee;
    }
}