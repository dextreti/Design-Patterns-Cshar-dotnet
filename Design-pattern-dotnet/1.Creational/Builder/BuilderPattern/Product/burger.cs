using System.Text;

namespace Builder;

public class Burger
{
    public bool Cheese { get; set; }
    public bool Lettuce { get; set; }
    public bool Tomato { get; set; }
    public bool Onion { get; set; }
    public bool Dip { get; set; }

    public override string ToString()
    {
        string cheese = Cheese ? "\n- Cheese : Yes" : "";
        string lettuce = Lettuce ? "\n- Lettuce : Yes" : "";
        string tomato = Tomato ? "\n- Tomato : Yes" : "";
        string onion = Onion ? "\n- Onion : Yes" : "";
        string dip = Dip ? "\n- Onion : Yes" : "";

        StringBuilder builder = new StringBuilder();
        builder.Append(cheese);
        builder.Append(lettuce);
        builder.Append(tomato);
        builder.Append(onion);
        builder.Append(dip);

        return builder.ToString();
    }
}