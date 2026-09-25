using System;
using designlibtest.builder;

namespace designlibtest;

public class BuilderPatternTest
{
    [Fact]
    public void TestIfHighPerformanceCpuHasTheCorrectSettings()
    {
        ComputerDirector computerDirector = new ComputerDirector();
        Computer computer = computerDirector.Construct(new HighPerformanceCPUBuilder());
        Assert.Equal("Intel Core Ultra 7",computer.Cpu);
        Assert.Equal("DDR5-6000 CL30",computer.Ram);
        Assert.Equal("GigaByte",computer.MotherBoard);
        Assert.Equal("Nvidia RTX 4070",computer.Graphics);
        Assert.Equal("Foxin",computer.Smps);
    }
}
