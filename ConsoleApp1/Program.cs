

string input = Console.ReadLine();
int iteration = Convert.ToInt32(input);
int result = 0;

for  (int i = 0; i < iteration; i++)
{
string number = Console.ReadLine();
    string[] numberArr = number.Split(new char[] { ' ' });
    int a = Convert.ToInt32(numberArr[0]);
    int b = Convert.ToInt32(numberArr[1]);
    int c = Convert.ToInt32(numberArr[2]);

    result = result + (a + b + c);
}
if (result == 0)
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");