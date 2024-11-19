namespace Iterator;

public class Tasks : ITask<string>
{
    private List<string> tasks = new List<string>();

    public void Add(string task)
    {
        tasks.Add(task);
    }
    public IIterator<string> CreateIterator()
    {
        return new Iterator(tasks);
    }
}


