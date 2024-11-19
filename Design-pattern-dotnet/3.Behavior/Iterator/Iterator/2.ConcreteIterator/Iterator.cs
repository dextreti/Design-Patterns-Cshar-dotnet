namespace Iterator;

public class Iterator : IIterator<string>
{
    private List<string> tasks;
    private int index = 0;

    public Iterator(List<string> tasks)
    {
        this.tasks = tasks;
    }

    public bool HasNext()
    {
        return index < tasks.Count;
    }

    public string Next()
    {
        if (HasNext())
        {
            string task = tasks[index];
            index++;
            return task;
        }
        else
        {
            throw new InvalidOperationException("No more tasks to iterate.");
        }
    }
}
