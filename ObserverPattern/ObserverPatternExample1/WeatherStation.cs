public class WeatherStation
{
    public static void main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
    }
}