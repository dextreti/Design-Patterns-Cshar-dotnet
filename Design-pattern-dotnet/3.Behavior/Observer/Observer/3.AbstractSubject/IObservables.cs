namespace ObserverPattern;

public interface IObservable<T>
{
    void Subscribe(T observer);
    void UnSubscribe(T observer);
    void Notify(string message);

}
