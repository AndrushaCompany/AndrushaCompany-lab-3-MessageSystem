using System;
using System.Diagnostics;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messenger;

public class Messenger : IMessenger
{
    public string Name { get; }

    public Messenger(string name)
    {
        Name = name;
    }
    
    public void ShowText(string message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        Console.Write("Messenger " + Name + ": " + message);
    }

    public void SendMessege(string messege)
    {
        //logic of external interaction
        ShowText(messege);
    }
}