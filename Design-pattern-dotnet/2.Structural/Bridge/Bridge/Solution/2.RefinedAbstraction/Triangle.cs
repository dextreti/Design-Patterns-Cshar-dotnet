namespace Bridge.Solution;

internal class Triangle : Figure
{
    public Triangle(IColor color) : base(color) { }
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
        color.Paint();
    }

}
