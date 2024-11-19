using System.Dynamic;

namespace Composite;

public class MenuItem : IMenu
{
    private string Name;
    public MenuItem(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Item: {Name}");
    }
}
