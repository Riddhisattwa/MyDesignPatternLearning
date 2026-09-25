using System;

namespace designpatternlib.observer;

public interface IObserver:IDisplay
{
    public void Update(string message, string sender);
}
