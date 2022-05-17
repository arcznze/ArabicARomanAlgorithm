using System.Text.RegularExpressions;

string input;
string[] x = new string[6];
string[] unit = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
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
    if (int.Parse(input) >= 1000000)
        Console.WriteLine("You cannot write numbers greater than a million.");
    else if (int.Parse(input) <= 0)
        Console.WriteLine("You must write numbers greater than zero.");
    else
        GetDigit();
}
void GetDigit()
{
    for (int i = 0; i < input.Length; i++)
    {
        x[i] = input.Substring(i, 1);
    }
    GetRomans();
}
void GetRomans()
{
    if (input.Length == 1)
    {
        int a = int.Parse(x[0]);
        string b = unit[a];
        Console.WriteLine(b);
    }
    else
        Console.WriteLine("");
    
}