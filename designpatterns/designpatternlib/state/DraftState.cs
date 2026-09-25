using System;

namespace designpatternlib.state;

public class DraftState : IDocumentState
{
    public void Process(Document document)
    {
        document.Text = "Sample Document";
        document.State = States.Draft;
        document.Name = string.IsNullOrEmpty(document.Name)?"Untitled document": document.Name;
    }
}
