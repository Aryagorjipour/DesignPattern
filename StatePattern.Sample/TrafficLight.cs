using StatePattern.Sample.Abstractions;
using StatePattern.Sample.Concretes;

namespace StatePattern.Sample;
public class TrafficLight
{
    private ITrafficLightState _state;
    public TrafficLight()
    {
        _state = new RedState();
    }

    public void ChangeState(ITrafficLightState state)
    {
        _state = state;
    }

    public void Handle()
    {
        _state.Handle();
    }
}
