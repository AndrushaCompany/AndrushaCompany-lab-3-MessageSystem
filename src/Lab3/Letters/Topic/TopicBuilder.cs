using System;
using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic;

public class TopicBuilder : ITopicBuilder
{
    private string? _title;
    private IAdressee? _adressee;

    public TopicBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public TopicBuilder WithAdressee(IAdressee adressee)
    {
        _adressee = adressee;
        return this;
    }

    public Topic Build()
    {
        if (_title is not null && _adressee is not null)
        return new Topic(_title, _adressee);
        
        throw new InvalidOperationException("No necessary arguments for the topic");
    }
}