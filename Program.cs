bool running = true;
while (running)
{
  Console.WriteLine("Please choose 'list', 'lend', 'return' or 'exit'");
  string? userInput = Console.ReadLine();

  switch (userInput)
  {
    case "list":
      Console.WriteLine("Listing available books");
      break;

    case "lend":
      Console.WriteLine("Lending a book");
      break;

    case "return":
      Console.WriteLine("Returning a book");
      break;

    case "exit":
      Console.WriteLine("Closing program");
      running = false;
      break;

    default:
      Console.WriteLine("Unrecognized command!");
      break;
  }
}
