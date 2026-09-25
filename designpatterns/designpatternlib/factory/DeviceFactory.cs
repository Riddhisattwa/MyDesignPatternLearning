using System;

namespace designpatternlib.factory;

public abstract class DeviceFactory
{
    public abstract HandheldDevice CreateHandHeldDevice();
    public abstract void SetScreenSize();
}
