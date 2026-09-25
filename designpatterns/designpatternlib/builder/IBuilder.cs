using System;

namespace designlibtest.builder;

public interface IBuilder
{
    public void BuildProcessor();
    public void BuildSmps();
    public void BuildMotherBoard();

    public void BuildGraphicsMemory();

    public void BuildRam();

    public Computer GetFinishedProduct();

}
