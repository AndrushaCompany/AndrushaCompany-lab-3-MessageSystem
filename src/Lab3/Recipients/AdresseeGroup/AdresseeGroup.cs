using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Adressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.AdresseeGroup;

public class AdresseeGroup : IAdressee
{
    private List<IAdressee>? _adressees;

    public AdresseeGroup(IEnumerable<IAdressee> adressees)
    {
        _adressees = (List<IAdressee>?)adressees;
    }

    public void MessageSending(Message.Message message)
    {
        if (_adressees != null)
            for (int i = 0; i < _adressees.Count; ++i)
            {
                _adressees[i].MessageSending(message);
            }
    }
}