namespace solidlib;

public class Book
{
    private long _id;
    private string _isbn;
    private string _title;

    private BorrowState _borrowState;

    public string ISBN
    {
        get => _isbn;
    }
    public string Title
    {
        get => _title;
    }

    public long Id
    {
        get => _id;
    }

    public Book(int id, string isbn, string title)
    {
        _id = id;
        _isbn = isbn;
        _title = title;
        _borrowState = BorrowState.AVAILABLE;
    }

    public void LoanBook()
    {
        _borrowState = BorrowState.BORROWED;
    }

    public void RecieveBook()
    {
        _borrowState = BorrowState.AVAILABLE;
    }

}
