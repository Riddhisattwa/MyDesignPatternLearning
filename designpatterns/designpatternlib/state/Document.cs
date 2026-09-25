using System;

namespace designpatternlib.state;

public class Document
{
    private string _text;
    private string _name;

    private States _state;

    private IDocumentState _internalDocumentState;

    public string Text
    {
        get => _text;
        set => _text = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public States State
    {
        get => _state;
        set => _state = value;
    }
    public Document()
    {
        _internalDocumentState = new DraftState();
        _internalDocumentState.Process(this);
    }
    public Document(string name)
    {
        _name = name;
        _internalDocumentState = new DraftState();
        _internalDocumentState.Process(this);
    }
    public void SaveDocument()
    {
        _internalDocumentState = new SavedState();
        _internalDocumentState.Process(this);
    }
    public void DeleteDocument()
    {
        _internalDocumentState = new DeletedState();
        _internalDocumentState.Process(this);
    }
    public void PrintDocument()
    {
        if(State == States.Saved)
        {
            _internalDocumentState = new PrintState();
            _internalDocumentState.Process(this);
        }
    }
}
