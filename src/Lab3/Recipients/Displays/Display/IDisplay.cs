namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Display;

public interface IDisplay
{
    public void ShowColorText(string message);

    public void WriteText(string message, string? path);
}