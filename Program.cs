
Book martian = new Book("Martian", "Jane Doe", new DateTime(2004, 10, 10));

Console.WriteLine("Book title: " + martian.Title);
Console.WriteLine("Author: " + martian.Author);
Console.WriteLine("Book first published: " + martian.FirstPublished);


Library library = new Library();

Book? book1 = library.LendBook("Martian");
Console.WriteLine("Lending book: " + book1.Title);

Book? book2 = library.LendBook("Gang of Four");
Console.WriteLine("Lending book: " + book2?.Title);
