using System.Text.RegularExpressions;

string input;
string[] x = new string[6];
string[] unit = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
string[] thousand = { "", "M", "MM", "MMM", "|IV|", "|V|", "|V|M", "|V|MM", "|V|MMM", "|IX|" };
string[] tenthousand = { "", "|X|", "|XX|", "|XXX|", "|XL|", "|L|", "|LX|", "|LXX|", "|LXXX|", "|XC|" };
string[] hundredthousand = { "", "|C|", "|CC|", "|CCC|", "|CD|", "|D|", "|DC|", "|DCC|", "|DCCC|", "|CM|" };
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
    else if (input.Length == 2)
    {
        int c = int.Parse(x[0]);
        string d = ten[c];
        int a = int.Parse(x[1]);
        string b = unit[a];
        Console.WriteLine(d + b);
    }
    else if(input.Length == 3)
    {
        int e = int.Parse(x[0]);
        string f = hundred[e];
        int c = int.Parse(x[1]);
        string d = ten[c];
        int a = int.Parse(x[2]);
        string b = unit[a];
        Console.WriteLine(f + d + b);
    }
    else if(input.Length == 4)
    {
        int g = int.Parse(x[0]);
        string h = thousand[g];
        int e = int.Parse(x[1]);
        string f = hundred[e];
        int c = int.Parse(x[2]);
        string d = ten[c];
        int a = int.Parse(x[3]);
        string b = unit[a];
        Console.WriteLine(h + f + d + b);
    }
    else if(input.Length == 5)
    {
        int i = int.Parse(x[0]);
        string j = tenthousand[i];
        int g = int.Parse(x[1]);
        string h = thousand[g];
        int e = int.Parse(x[2]);
        string f = hundred[e];
        int c = int.Parse(x[3]);
        string d = ten[c];
        int a = int.Parse(x[4]);
        string b = unit[a];
        Console.WriteLine(j + h + f + d + b);
    }
    else
    {
        int k = int.Parse(x[0]);
        string l = hundredthousand[k];
        int i = int.Parse(x[1]);
        string j = tenthousand[i];
        int g = int.Parse(x[2]);
        string h = thousand[g];
        int e = int.Parse(x[3]);
        string f = hundred[e];
        int c = int.Parse(x[4]);
        string d = ten[c];
        int a = int.Parse(x[5]);
        string b = unit[a];
        Console.WriteLine(l + j + h + f + d + b);
    }
}