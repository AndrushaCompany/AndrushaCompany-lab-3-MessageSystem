namespace Itmo.ObjectOrientedProgramming.Lab3.Adressee;

public interface IAdresseeBuilder
{
    IAdresseeBuilder WithFilter(int minimalLevel);
    IAdresseeBuilder WithLogger();
    
    IAdressee Build();
}