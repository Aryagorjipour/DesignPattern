using StatePattern.Sample.Abstractions;

namespace StatePattern.Sample.Concretes;
public class GreenState : ITrafficLightState
{
    public void Handle()
    {
        Console.WriteLine("Green light is on. Go!");
    }
}
