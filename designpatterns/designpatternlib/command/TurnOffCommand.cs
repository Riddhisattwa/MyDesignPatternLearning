using System;

namespace designpatternlib.command;

public class TurnOffCommand : ICommand
{
    private IDevice _device;
    public TurnOffCommand(IDevice device)
    {
        _device = device;
    }
    public void Execute()
    {
        _device.TurnOff();
    }
}
