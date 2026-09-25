using System;

namespace designpatternlib.state;

public class PrintState : IDocumentState
{
    public void Process(Document document)
    {
        document.State = States.Print;
    }
}
