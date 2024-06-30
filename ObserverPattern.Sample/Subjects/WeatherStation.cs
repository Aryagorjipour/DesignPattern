
namespace ObserverPattern.Sample.ConcreteSubject;
public class WeatherStation : Subject
{
    public void SetWeatherCondition(string weatherCondition)
    {
        base.WeatherCondition = weatherCondition;
        base.Notify();
    }
}
