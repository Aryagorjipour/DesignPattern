using StatePattern.Sample.Abstractions;

namespace StatePattern.Sample.Concretes;
public class YellowState : ITrafficLightState
{
    public void Handle()
    {
        Console.WriteLine("Yellow light is on. Prepare to stop!");
    }
}
