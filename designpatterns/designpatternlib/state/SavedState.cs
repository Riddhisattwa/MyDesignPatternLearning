using System;

namespace designpatternlib.state;

public class SavedState : IDocumentState
{
    public void Process(Document document)
    {
        document.State = States.Saved;
    }
}
