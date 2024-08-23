


using System.Text.RegularExpressions;

string input = Console.ReadLine();

//var inputArr = input.ToCharArray();

int quantityOf4 = input.Where( c => c.Equals('4')).Count();
int quantityOf7 = input.Where(c => c.Equals('7')).Count();

int result = quantityOf4 + quantityOf7;

if (result == 4 || result == 7)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");
