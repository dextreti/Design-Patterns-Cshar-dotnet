namespace Bridge.Solution;

internal class Rectangle : Figure
{
    public Rectangle(IColor color) : base(color) { }
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
        color.Paint();
    }
}

