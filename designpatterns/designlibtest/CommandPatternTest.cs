using System;
using designpatternlib.command;

namespace designlibtest;

public class CommandPatternTest
{
[Fact]
public void TestIfTvturnsOnAndOff()
    {
        RemoteControl remoteControl = new();
        Tv tv = new();
        remoteControl.SetCommand(new TurnOnCommand(tv));
        remoteControl.PressButton();
        Assert.Equal(DeviceState.On, tv.GetCurrentState());
        remoteControl.SetCommand(new TurnOffCommand(tv));
        remoteControl.PressButton();
        Assert.Equal(DeviceState.Off, tv.GetCurrentState());
    }
[Fact]
public void TestIfAcTurnsOnAndOff()
    {
        RemoteControl remoteControl = new();
        Ac ac = new();
        remoteControl.SetCommand(new TurnOnCommand(ac));
        remoteControl.PressButton();
        Assert.Equal(DeviceState.On, ac.GetCurrentState());
        remoteControl.SetCommand(new TurnOffCommand(ac));
        remoteControl.PressButton();
        Assert.Equal(DeviceState.Off, ac.GetCurrentState());
    }
}
