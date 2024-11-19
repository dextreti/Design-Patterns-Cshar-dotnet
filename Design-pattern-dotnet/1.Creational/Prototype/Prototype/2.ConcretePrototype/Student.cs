namespace Prototype;

public class Student : IPerson<Student>
{
    public string Name { get; set; } = string.Empty;
    public Contact? contact { get; set; }

    public Student Clone()
    {
        Student student = (Student)MemberwiseClone();
        student.contact = contact?.Clone();
        return student;
    }


}

public class Contact
{
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Contact Clone()
    {
        return (Contact)MemberwiseClone();
    }



}
