using System;

namespace designpatternlib.observer.dotnet;

public class StockTicker : IObservable<Stock>
{
    private readonly List<IObserver<Stock>> observers = new();
    public IDisposable Subscribe(IObserver<Stock> observer)
    {
        if(!observers.Contains(observer))
        {
            observers.Add(observer);
        }
        return new UnSubscriber(observers,observer);
    }
    public void UpdateStockPrice(string name, int value)
    {
        var stock = new Stock(name,value);
        foreach(IObserver<Stock> observer in observers)
        {
            observer.OnNext(stock);
        }
    }
    public void StopTicker()
    {
        foreach(var observer in observers)
        {
            observer.OnCompleted();
        }
        observers.Clear();
    }
}
