namespace Bridge.Solution;

public abstract class Figure
{
    protected IColor color;
    protected Figure(IColor color)
    {
        this.color = color;
    }

    public abstract void Draw();


}
