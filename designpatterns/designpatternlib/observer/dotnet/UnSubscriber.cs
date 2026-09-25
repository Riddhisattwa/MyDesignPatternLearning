using System;

namespace designpatternlib.observer.dotnet;

public class UnSubscriber : IDisposable
{
    private List<IObserver<Stock>> _observers;
    private IObserver<Stock> _observer;
    public UnSubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
    {
        _observers = observers;
        _observer = observer;
    }
    public void Dispose()
    {
        if(_observers !=null && _observers.Contains(_observer))
        {
            _observers.Remove(_observer);
        }
    }
}
