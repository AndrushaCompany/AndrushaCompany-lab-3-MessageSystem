using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Message;

public class Message
{
    public string Heading { get; }
    public string MainBody { get; }
    public int RelevanceLevel { get; }
    public bool Read { get; private set; }

    public Message(string heading, string mainBody, int relevanceLevel)
    {
        Heading = heading;
        MainBody = mainBody;
        RelevanceLevel = relevanceLevel;
        Read = false;
    }

    public void IsChecked()
    {
        if (Read)
        {
            throw new InvalidOperationException("Already read");
        }
        Read = true;
    }
}