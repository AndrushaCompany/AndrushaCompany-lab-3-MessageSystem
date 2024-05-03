using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Displays.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDisplayDriver : IDisplay
{
    public void SetColor(Color color);
    public void Clear();
}