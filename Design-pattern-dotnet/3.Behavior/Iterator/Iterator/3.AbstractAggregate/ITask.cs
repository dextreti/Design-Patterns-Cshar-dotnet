namespace Iterator;

public interface ITask<T>
{
    IIterator<T> CreateIterator();

}
