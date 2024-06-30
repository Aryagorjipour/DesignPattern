namespace ObserverPattern.Sample.Observers;
public class ForecastSystem : IObserver
{
    public void Update(string weatherCondition)
    {
        Console.WriteLine("ForecastSystem: Weather condition updated to " + weatherCondition);
    }
}
