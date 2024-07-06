using StatePattern.Sample;
using StatePattern.Sample.Concretes;

var trafficLight = new TrafficLight();
trafficLight.Handle();

trafficLight.ChangeState(new YellowState());
trafficLight.Handle();

trafficLight.ChangeState(new GreenState());
trafficLight.Handle();