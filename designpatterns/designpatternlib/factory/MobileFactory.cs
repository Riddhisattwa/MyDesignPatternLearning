using System;

namespace designpatternlib.factory;

public class MobileFactory : DeviceFactory
{
    private Mobile _mobile;
    public override HandheldDevice CreateHandHeldDevice()
    {
        _mobile = new();
        return _mobile;
    }

    public override void SetScreenSize()
    {
        _mobile.SetScreenSize("medium");
    }
}
