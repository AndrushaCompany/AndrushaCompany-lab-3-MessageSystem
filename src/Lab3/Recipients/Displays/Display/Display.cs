using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Display;

public class Display : IDisplay
{
    private Color _color = Color.Red;

    private string filePath = "Logs.txt";

    public Display(Color color)
    {
        _color = color;
    }
    
    public void ShowColorText(string message)
    {
        Debug.Assert(message != null, nameof(message) + " != null");
        Console.Clear();
        Console.WriteLine(Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message));
    }

    public void WriteText(string message, string? path)
    {
        if (path != null)
        {
            filePath = path;
        }
        
        using (var writer = new StreamWriter(filePath, true)) 
            { 
                writer.WriteLine(message);
            }
    }
}