Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine("You entered: " + number);
}
else
{
    Console.WriteLine("Error: not a number");
}