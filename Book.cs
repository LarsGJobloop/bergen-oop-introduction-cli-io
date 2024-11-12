class Book
{
  // Data fields
  public string Title;
  public string Author;
  public DateTime FirstPublished;

  // Constructur for the class, decides how to construct a valid object
  public Book(string title, string author, DateTime firstPublished)
  {
    Title = title;
    Author = author;
    FirstPublished = firstPublished;
  }
}