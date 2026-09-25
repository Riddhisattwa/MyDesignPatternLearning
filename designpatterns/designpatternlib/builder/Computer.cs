using System;

namespace designlibtest.builder;

public class Computer
{
  private string _cpu;
  private string _smps;
  private string _ram;
  private string _graphics;
  private string _motherboard;

  public string Cpu
    {
        get => _cpu;
        set => _cpu = value;
    }
    public string Smps
    {
        get => _smps;
        set => _smps = value;
    }
    public string Ram
    {
        get => _ram;
        set => _ram = value;
    }
    public string Graphics
    {
        get => _graphics;
        set => _graphics = value;
    }
    public string MotherBoard
    {
        get => _motherboard;
        set => _motherboard = value;
    }
}
