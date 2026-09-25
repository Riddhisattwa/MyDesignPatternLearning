using System;
using designpatternlib.state;

namespace designlibtest;

public class StatePatternTest
{
[Fact]
public void TestIfDocumentCanbeCreated()
    {
        Document document = new Document();
        Assert.Equal(States.Draft, document.State);
        Assert.Equal("Untitled document", document.Name);
        Assert.Equal("Sample Document", document.Text);
        document = new Document("Sample");
        Assert.Equal(States.Draft, document.State);
        Assert.Equal("Sample", document.Name);
        Assert.Equal("Sample Document", document.Text);
    } 
[Fact]    
public void TestIfDocumentCanBeSavedAndPrinted()
    {
        Document document = new Document("Sample");
        document.SaveDocument();
        document.PrintDocument();
        Assert.Equal(States.Print, document.State);
    }
[Fact]
public void TestIfDocumentCanBeDeletedAndCannotBePrinted()
    {
        Document document = new Document();
        document.DeleteDocument();
        document.PrintDocument();
        Assert.NotEqual(States.Print, document.State);
        Assert.Equal(States.Deleted, document.State);
    }
}
