class Library
{
  // Data fields
  List<Book> books;

  // Constructor
  public Library()
  {
    books = new List<Book>();
    books.Add(new Book("Martian", "Jane Doe", new DateTime(2004, 10, 10)));
    books.Add(new Book("Foundation", "Asimov", new DateTime(1940, 10, 10)));
  }

  // Methods, behaviour the class supports
  public Book? LendBook(string title)
  {
    Book? book = books.Find((book) =>
    {
      if (book.Title == title)
      {
        return true;
      }
      else
      {
        return false;
      }
    });

    if (book == null)
    {
      return null;
    }
    else
    {
      return book;
    }
  }
}