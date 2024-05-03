namespace Itmo.ObjectOrientedProgramming.Lab3.Message;

public interface IMessageBuilder
{
    IMessageBuilder WithHeading(string heading);
    IMessageBuilder WithMainBody(string mainBody);
    IMessageBuilder WithRelevanceLevel(int relevanceLevel);

    Message Build();
}