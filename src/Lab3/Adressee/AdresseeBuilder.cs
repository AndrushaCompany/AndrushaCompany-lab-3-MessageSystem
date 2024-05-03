namespace Itmo.ObjectOrientedProgramming.Lab3.Adressee;

public class AdresseeBuilder : IAdresseeBuilder
{
    private IAdressee Adressee;

    public AdresseeBuilder(IAdressee adressee)
    {
        Adressee = adressee;
    }

    public IAdresseeBuilder WithFilter(int minimalLevel)
    {
        Adressee = new AdresseeFilter(Adressee, minimalLevel);
        return this;
    }

    public IAdresseeBuilder WithLogger()
    {
        Adressee = new AdresseeLog(Adressee);
        return this;
    }
    
    public IAdressee Build()
    {
        return Adressee;
    }
}