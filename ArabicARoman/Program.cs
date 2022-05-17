using System.Text.RegularExpressions;

string input;
Console.WriteLine("Enter a number: ");
input = Console.ReadLine();

Regex regex = new Regex(@"^\d+$");
if (regex.IsMatch(input))
{
    Check();
}
else
    Console.WriteLine("You can only write numbers.");

void Check()
{
    if (int.Parse(input) <= 0)
        Console.WriteLine("You can only write numbers greater than zero.");
    else if (int.Parse(input) >= 1000000)
        Console.WriteLine("You cannot write numbers greater than a million.");
    else
        Console.WriteLine("Valid");
}
