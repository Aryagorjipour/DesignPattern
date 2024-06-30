namespace ObserverPattern.Sample;
public abstract class Subject
{
    public readonly List<IObserver> _observers;
    private string _weatherCondition;

    public Subject()
    {
        _observers = new List<IObserver>();
    }

    public string WeatherCondition { get => _weatherCondition; set => _weatherCondition = value; }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void DeAttach(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_weatherCondition);
        }
    }
}
