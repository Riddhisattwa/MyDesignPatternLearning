using System;

namespace designlibtest.builder;

public class ComputerDirector
{
    public Computer Construct(IBuilder builder)
    {
        builder.BuildMotherBoard();
        builder.BuildProcessor();
        builder.BuildSmps();
        builder.BuildGraphicsMemory();
        builder.BuildRam();
        return builder.GetFinishedProduct();
    }
}
