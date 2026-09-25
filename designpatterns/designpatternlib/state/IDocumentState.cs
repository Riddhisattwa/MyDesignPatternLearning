using System;

namespace designpatternlib.state;

public interface IDocumentState
{
    public void Process(Document document);
}
