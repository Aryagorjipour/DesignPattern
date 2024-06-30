namespace ObserverPattern.Sample.Observers;
public class DisplayBoard : IObserver
{
    public void Update(string weatherCondition)
    {
        Console.WriteLine("DisplayBoard: Weather condition updated to " + weatherCondition);
    }
}
