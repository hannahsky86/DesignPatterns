
public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void display()
    {
        throw new System.NotImplementedException();
    }

    public void update(float temp, float humidity, float pressure)
    {
        throw new System.NotImplementedException();
    }
}