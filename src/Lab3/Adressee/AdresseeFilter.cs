using System;
using System.Diagnostics;

namespace Itmo.ObjectOrientedProgramming.Lab3.Adressee;

public class AdresseeFilter : IAdressee
{
    public int MinimalLevel { get; }
    public IAdressee Adressee { get; }

    public void MessageSending(Message.Message message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        if (message.RelevanceLevel < MinimalLevel)
        {
            throw new InvalidOperationException("Relevance level is too low");
        }
        Adressee.MessageSending(message);
    }
    
    public AdresseeFilter (IAdressee adressee, int minimalLevel)
    {
        Adressee = adressee;
        MinimalLevel = minimalLevel;
    }
}