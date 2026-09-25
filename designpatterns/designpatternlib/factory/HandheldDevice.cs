using System;

namespace designpatternlib.factory;

public abstract class HandheldDevice
{
    private string _screensize;
    public string ScreenSize
    {
        get => _screensize;
    }
    public abstract string ShowStartScreen();
    public void SetScreenSize(string value)
    {
        _screensize = value;
    }
}
