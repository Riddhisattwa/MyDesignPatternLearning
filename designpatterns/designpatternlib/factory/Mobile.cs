using System;

namespace designpatternlib.factory;

public class Mobile : HandheldDevice
{
    public override string ShowStartScreen()
    {
        return "Apple Iphone 17";
    }
}
