public class Inventory
{
    private Book[] books;

    public Inventory(Book[] books)
    {
        this.books = books;
    }

    public Book GetBook(string serialNumber)
    {
        foreach(Book book in books)
        {
            if (book.GetSerialNumber().Equals(serialNumber))
            {
                return book;
            }
        }

        return null;
    }

    public Book GetBookName(string BookName)
    {
        foreach(Book book in books)
        {
            if (book.GetBookName().Equals(BookName))
            {
                return book;
            }
        }

        return null;
    } 

    public Book Search(Book searchBook) 
    {
        foreach(Book book in books)
        { 
            string serialNumber = searchBook.GetSerialNumber();
            string BookName = searchBook.GetBookName();

            if (book.GetSerialNumber().Equals(serialNumber) || book.GetBookName().Equals(BookName))
            {
                return book;
            }

        }

        return null;
    }
}