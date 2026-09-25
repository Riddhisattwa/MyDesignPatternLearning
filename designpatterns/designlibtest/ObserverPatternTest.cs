using System;
using System.Net;
using designpatternlib.observer;
using designpatternlib.observer.dotnet;

namespace designlibtest;

public class ObserverPatternTest
{
    [Fact]
    public void TestIfTheObserverAreGettingNotified()
    {
        IObserver tv = new TvSubscriber();
        IObserver mobile = new MobileSubscriber();
        WeatherStation weatherStation = new WeatherStation();
        weatherStation.addObserver(tv);
        weatherStation.addObserver(mobile);
        weatherStation.CheckWeather(1);
        Assert.Contains(string.Format("TV display=Current weather status={0}",WeatherState.Sunshine.ToString()),tv.Display());
        Assert.Contains(string.Format("Mobile display=Current weather status={0}",WeatherState.Sunshine.ToString()),mobile.Display());
    }
    [Fact]
    public void TestIfRemoveSubscriberIsNotNotified()
    {
        IObserver tv = new TvSubscriber();
        IObserver mobile = new MobileSubscriber();
        WeatherStation weatherStation = new WeatherStation();
        weatherStation.addObserver(tv);
        weatherStation.addObserver(mobile);
        weatherStation.CheckWeather(1);
        Assert.Contains(string.Format("TV display=Current weather status={0}",WeatherState.Sunshine.ToString()),tv.Display());
        Assert.Contains(string.Format("Mobile display=Current weather status={0}",WeatherState.Sunshine.ToString()),mobile.Display());
        weatherStation.removeObserver(mobile);
        weatherStation.CheckWeather(1);
        Assert.Contains(string.Format("TV display=Current weather status={0}",WeatherState.Sunshine.ToString()),tv.Display());
        Assert.Contains(string.Format("Mobile display=Current weather status={0}",WeatherState.Sunshine.ToString()),mobile.Display());
    }
    [Fact]
    public void TestIfStockIsUpdatedOnceSubscribed()
    {
        StockTicker ticker = new StockTicker();
        StockMonitor tv = new StockMonitor("TV");
        StockMonitor mobile = new StockMonitor("Mobile");

        tv.Subscribe(ticker);
        mobile.Subscribe(ticker);

        ticker.UpdateStockPrice("ABP",123);
        Assert.Equal("TV", tv.DisplayMonitorName());
        Assert.Equal("Stock name is ABP value is 123", tv.Display());
        Assert.Equal("Mobile", mobile.DisplayMonitorName());
        Assert.Equal("Stock name is ABP value is 123", mobile.Display());

        mobile.UnSubscribe();
        ticker.UpdateStockPrice("ACB", 111);
        Assert.Equal("Stock name is ACB value is 111", tv.Display());
        Assert.Equal("Stock name is ABP value is 123", mobile.Display());

    }

}
