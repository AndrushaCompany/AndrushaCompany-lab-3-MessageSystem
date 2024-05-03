using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic;

public interface ITopicBuilder
{
    public TopicBuilder WithTitle(string title);

    public TopicBuilder WithAdressee(IAdressee adressee);

    public Topic Build();
}