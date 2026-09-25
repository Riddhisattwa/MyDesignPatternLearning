using System;

namespace designpatternlib.factory;

public class TabletFactory : DeviceFactory
{
    private Tablet _tablet;
    public override HandheldDevice CreateHandHeldDevice()
    {
        _tablet = new();
        return _tablet;
    }

    public override void SetScreenSize()
    {
        _tablet.SetScreenSize("large");
    }
}
