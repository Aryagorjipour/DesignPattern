using ObserverPattern.Sample.ConcreteSubject;
using ObserverPattern.Sample.Observers;

WeatherStation weatherStation = new WeatherStation();

DisplayBoard displayBoard = new DisplayBoard();
ForecastSystem forecastSystem = new ForecastSystem();


weatherStation.Attach(displayBoard);
weatherStation.Attach(forecastSystem);


weatherStation.SetWeatherCondition("Sunny");
weatherStation.SetWeatherCondition("Rainy");
weatherStation.SetWeatherCondition("Cloudy");
weatherStation.DeAttach(forecastSystem);

weatherStation.SetWeatherCondition("Windy");