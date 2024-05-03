using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Message;

public class MessageBuilder : IMessageBuilder
{
    private string? _heading;
    private string? _mainBody;
    private int _relevanceLevel;

    public IMessageBuilder WithHeading(string heading)
    {
        _heading = heading;
        return this;
    }

    public IMessageBuilder WithMainBody(string mainBody)
    {
        _mainBody = mainBody;
        return this;
    }

    public IMessageBuilder WithRelevanceLevel(int relevanceLevel)
    {
        _relevanceLevel = relevanceLevel;
        return this;
    }

    public Message Build()
    {
        if (_heading is not null && _mainBody is not null)
        return new Message(_heading, _mainBody, _relevanceLevel);
        
        throw new InvalidOperationException("No necessary arguments for the message");
    }
}