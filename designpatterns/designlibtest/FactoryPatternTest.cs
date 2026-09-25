using System;
using designpatternlib.factory;

namespace designlibtest;

public class FactoryPatternTest
{
    [Fact]
    public void TestIfDevicesAreCreatedProperly()
    {
        DeviceFactory deviceFactory = new MobileFactory();
        HandheldDevice handheldDevice = deviceFactory.CreateHandHeldDevice();
        Assert.Equal("Apple Iphone 17", handheldDevice.ShowStartScreen());
        deviceFactory.SetScreenSize();
        Assert.Equal("medium", handheldDevice.ScreenSize);

        deviceFactory = new TabletFactory();
        handheldDevice = deviceFactory.CreateHandHeldDevice();
        Assert.Equal("Apple Ipad Mini", handheldDevice.ShowStartScreen());
        deviceFactory.SetScreenSize();
        Assert.Equal("large", handheldDevice.ScreenSize);
    }

}
