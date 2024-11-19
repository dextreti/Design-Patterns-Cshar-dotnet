namespace Bridge.Solution;
internal class Circle : Figure
{
    public Circle(IColor color) : base(color) { }
    public override void Draw()
    {
        Console.WriteLine("Drawing circle");
        color.Paint();
    }

}

