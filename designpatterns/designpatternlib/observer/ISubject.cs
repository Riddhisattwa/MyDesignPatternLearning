using System;

namespace designpatternlib.observer;

public interface ISubject
{
    public bool addObserver(IObserver observer);
    public bool removeObserver(IObserver observer);
    public bool notify(); 
}
