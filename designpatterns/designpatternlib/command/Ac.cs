using System;

namespace designpatternlib.command;

public class Ac : IDevice
{
    private DeviceState _deviceState;
    public void TurnOff()
    {
        _deviceState = DeviceState.Off;
    }

    public void TurnOn()
    {
        _deviceState = DeviceState.On;
    }

    public DeviceState GetCurrentState()
    {
        return _deviceState;
    }
}
