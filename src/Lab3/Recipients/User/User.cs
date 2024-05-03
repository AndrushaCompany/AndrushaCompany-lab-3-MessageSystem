using System;
using System.Collections.Generic;
using System.Diagnostics;
using Itmo.ObjectOrientedProgramming.Lab3.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.User;

public class User : IUser
{
    public int ID { get; }
    
    private List<Message.Message> Messages = new();

    private MessageBuilder Builder;
    
    public User(MessageBuilder builder, int id)
    {
        Builder = builder;
        ID = id;
    }

    public Message.Message GetMessage(int index) //for tests
    {
        if (index < Messages.Count)
        {
            return Messages[index];
        }

        throw new InvalidOperationException("Wrong index");
    }
    public void MessageSending(Message.Message message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        Messages.Add(Builder.WithHeading(message.Heading).
            WithMainBody(message.MainBody).WithRelevanceLevel(message.RelevanceLevel).Build());
    }

    public void ChangeToRead(Message.Message message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        message.IsChecked();
    }
}