namespace Composite;

public class Menu : IMenu
{
    private List<IMenu> Items = new List<IMenu>();
    private string Name;

    public Menu(string name)
    {
        Name = name;
    }

    public void AddItem(IMenu items)
    {
        Items.Add(items);
    }
    public void Display()
    {
        Console.WriteLine($"Menu:{Name}");
        foreach (var item in Items)
        {
            item.Display();
        }
    }
}
