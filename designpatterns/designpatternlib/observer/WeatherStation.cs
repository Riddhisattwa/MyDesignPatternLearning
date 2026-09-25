using System;

namespace designpatternlib.observer;

public class WeatherStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private WeatherState weatherstate;

    private string message;

    public bool addObserver(IObserver observer)
    {
        observers.Add(observer);
        return true;
    }

    public bool notify()
    {
        foreach(IObserver observer in observers)
        {
            observer.Update(message, this.GetType().ToString());
        }
        return true;
    }

    public bool removeObserver(IObserver observer)
    {
        observers.Remove(observer);
        return true;
    }
    public void CheckWeather(int val)
    {
        if (Enum.IsDefined(typeof(WeatherState), val))
        {
            weatherstate = (WeatherState)val;
            message = weatherstate.ToString();
        }
        else
            message = "Unknown weather state";
        notify();
    }
}
