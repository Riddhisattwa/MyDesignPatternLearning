using System;
using Microsoft.VisualBasic;

namespace designpatternlib.observer.dotnet;

public class StockMonitor : IObserver<Stock>
{
    private string _monitorName;
    private string message;

    private IDisposable token;

    public StockMonitor(string name)
    {
        _monitorName =name;
    }

    public string Display()
    {
        return message;
    }

    public string DisplayMonitorName()
    {
        return _monitorName;
    }

    public void Subscribe(IObservable<Stock> observable)
    {
        token = observable.Subscribe(this);
    }

    public void UnSubscribe()
    {
        token?.Dispose();
    }

    public void OnCompleted()
    {
        message = string.Format("No more updates");
    }

    public void OnError(Exception error)
    {
        throw new InvalidStockOperationException(error.Message);
    }

    public void OnNext(Stock value)
    {
        message = string.Format("Stock name is {0} value is {1}",value.Name, value.Value);
    }
}
public class InvalidStockOperationException:Exception
{
    public InvalidStockOperationException(string msg):base(msg)
    {
        
    }
}
