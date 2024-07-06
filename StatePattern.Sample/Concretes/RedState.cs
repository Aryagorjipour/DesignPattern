using StatePattern.Sample.Abstractions;

namespace StatePattern.Sample.Concretes;
public class RedState : ITrafficLightState
{
    public void Handle()
    {
        Console.WriteLine("Red light is on. Stop!");
    }
}
