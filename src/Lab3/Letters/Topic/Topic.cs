using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic;

public class Topic : ITopic
{
    private string Title { get; }

    private IAdressee _Adressee;

    public Topic(string title, IAdressee adressee)
    {
        Title = title;
        _Adressee = adressee;
    }
    
    public void Send(Message.Message message)
    {
        _Adressee.MessageSending(message);
    }
    
}