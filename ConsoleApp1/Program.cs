
using System.Text.RegularExpressions;

string unput = Console.ReadLine();
Regex regex0 = new Regex(@"0000000(\w*)");
MatchCollection matches0 = regex0.Matches(unput);
Regex regex1 = new Regex(@"1111111(\w*)");
MatchCollection matches1 = regex1.Matches(unput);

if (matches0.Count > 0 || matches1.Count > 0)
{
        Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}



