using System;
using designpatternlib.singleton;

namespace designlibtest;

public class SingletonTest
{
    [Fact]
    public void TestForSingletonInNormalCase()
    {
        DataBaseOpener obj1 = DataBaseOpener.GetInstance();
        DataBaseOpener obj2 = DataBaseOpener.GetInstance();
        Assert.Equal(obj1,obj2);
    }
    [Fact]
    public async Task TestForSingletonInThreadedCase()
    {
        DataBaseOpener obj1,obj2;
        Task<DataBaseOpener> task1 = Task.Run(() => DataBaseOpener.GetInstance());
        Task<DataBaseOpener> task2 = Task.Run(() => DataBaseOpener.GetInstance());
        obj1 = await task1;
        obj2 = await task2;
        Assert.Equal(obj1,obj2);
    }
}
