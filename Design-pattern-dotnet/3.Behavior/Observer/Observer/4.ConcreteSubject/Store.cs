namespace ObserverPattern;

public class Store<T> : IObservable<T>
{
    private readonly List<T> observables = new List<T>();
    public void Subscribe(T observer)
    {
        observables.Add(observer);

    }

    public void UnSubscribe(T observer)
    {
        observables.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var obs in observables)
        {
            if (obs is IObserver<T> observer)
            {
                observer.Update(message);
            }
        }
    }

    public void NotifyStockProduct(string To)
    {
        Notify(To);

    }

}
