using System;

namespace designpatternlib.factory;

public class Tablet : HandheldDevice
{
    public override string ShowStartScreen()
    {
        return "Apple Ipad Mini";
    }
}
