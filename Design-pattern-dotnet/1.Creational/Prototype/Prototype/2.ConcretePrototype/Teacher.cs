namespace Prototype;

public class Teacher : IPerson<Teacher>
{
    public string Name { get; set; } = string.Empty;


    public Teacher Clone()
    {
        return (Teacher)MemberwiseClone();
    }

}
