Console.WriteLine("Please enter either 'a' or 'b'");
string? userInput = Console.ReadLine();

switch (userInput)
{
  case "a":
    Console.WriteLine("Running command 'a'");
    break;

  case "b":
    Console.WriteLine("Running command 'b'");
    break;

  default:
    Console.WriteLine("Unrecognized command!");
    break;
}