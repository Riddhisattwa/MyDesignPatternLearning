using System;

namespace designpatternlib.state;

public class DeletedState : IDocumentState
{
    public void Process(Document document)
    {
        document.State = States.Deleted;
    }
}
