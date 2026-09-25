using System;

namespace designpatternlib.observer.dotnet;

public class Stock
{
    string _name;
    double _value;
    public string Name
    {
        get => _name;
        //set => _name = value;
    }
    public double Value
    {
        get => _value;
        set => _value = value;
    }
    public Stock(string name, int value)
    {
        _name = name;
        _value = value;
    }
}
