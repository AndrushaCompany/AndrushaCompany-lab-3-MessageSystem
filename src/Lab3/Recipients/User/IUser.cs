using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.User;

public interface IUser : IAdressee
{
    public void ChangeToRead(Message.Message message);
}