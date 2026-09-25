using System;

namespace designpatternlib.command;

public class TurnOnCommand : ICommand
{
    IDevice _device;
    public TurnOnCommand(IDevice device)
    {
      _device = device;
    }
    public void Execute()
    {
        _device.TurnOn();
    }
}
