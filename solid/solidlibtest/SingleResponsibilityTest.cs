using solidlib;

namespace solidlibtest;

public class SingleResponsibilityTest
{
    [Fact]
    public void Book_Should_Store_Its_Identity_And_Metadata()
    {
        var book = new Book(101, "978-12345-678-9", "Clean Code");

        Assert.Equal(101, book.Id);
        Assert.Equal("978-12345-678-9", book.ISBN);
        Assert.Equal("Clean Code", book.Title);
    }

    [Fact]
    public void Book_Should_Be_Able_To_Be_Loan_And_Returned()
    {
        var book = new Book(102, "978-98765-432-1", "The Pragmatic Programmer");

        book.LoanBook();
        book.RecieveBook();

        Assert.Equal(102, book.Id);
        Assert.Equal("978-98765-432-1", book.ISBN);
        Assert.Equal("The Pragmatic Programmer", book.Title);
    }

    [Fact]
    public void Book_Should_Not_Be_Responsible_For_Changing_Its_Own_Loan_State()
    {
        var book = new Book(103, "978-11111-222-3", "Refactoring");

        var exception = Assert.Throws<InvalidOperationException>(() => book.LoanBook());

        Assert.Equal("Loan management should be handled by a specialized service.", exception.Message);
    }
}
