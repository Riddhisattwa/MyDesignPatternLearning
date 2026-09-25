using System;

namespace designlibtest.builder;

public class HighPerformanceCPUBuilder:IBuilder
{
    private Computer _computer;
    public HighPerformanceCPUBuilder()
    {
        _computer = new Computer();
    }
     public void BuildProcessor()
    {
        _computer.Cpu = "Intel Core Ultra 7";
    }
    public void BuildSmps()
    {
        _computer.Smps = "Foxin";
    }
    public void BuildMotherBoard()
    {
        _computer.MotherBoard = "GigaByte";
    }

    public void BuildGraphicsMemory()
    {
        _computer.Graphics = "Nvidia RTX 4070";
    }

    public void BuildRam()
    {
        _computer.Ram = "DDR5-6000 CL30";
    }

    public Computer GetFinishedProduct()
    {
        return _computer;
    }
}
