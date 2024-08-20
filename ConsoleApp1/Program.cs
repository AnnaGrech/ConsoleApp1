////using Microsoft.VisualBasic;


////int iteration = Convert.ToInt32(Console.ReadLine());
////int result = 0;
////do
////{
////    string a = "++X";
////    string b = "+X+";
////    string c = "X++";

////    string input = Console.ReadLine();
////    if (input == a || input == b || input == c)
////        result++;
////    else result--;
////    iteration--;

////}
////while (iteration > 0);

////Console.WriteLine(result);

//iteration++;
//Console.WriteLine(iteration);

//using static System.Net.Mime.MediaTypeNames;
//using System.Data.SqlTypes;
//using System.Diagnostics.CodeAnalysis;

//string income = Console.ReadLine();
//income = income.ToLower();
//string result = income;

//for (var i = 0; i < income.Length; i++)
//{
//    if (income[i] != 'a' || income[i] != 'o' || income[i] != 'y' || income[i] != 'e' ||
//        income[i] != 'u' || income[i] != 'i')
//    {
//        result = income.Remove(i);
//    }

//}

////string substring = ".";
////for (var a = 0; a < income.Length; 
////{
////    income = income.Insert(a, substring);
////}
//Console.WriteLine(result);

//string[] incomeArr = income.Split(new char[] {});

//for (int i = 0; i < incomeArr.Length; i++)
//    incomeArr[i] = 

//int x = Convert.ToInt32(Console.ReadLine());
//int steps = 0;
//do
//{
//    x = x - 5;
//    steps = steps + 1;
//}
//while (x >= 5);

//if (x >= 4)
//{
//    x = x - 4;
//    steps = steps + 1;
//}

//if (x >= 3)
//{
//    x = x - 3;
//    steps = steps + 1;
//}

//if (x >= 2)
//{
//    x = x - 2;
//    steps = steps + 1;
//}

//if (x >= 1)
//{
//    x = x - 1;
//    steps = steps + 1;
//}
//Console.WriteLine(steps);

//using System.Diagnostics.Tracing;

//string input = Console.ReadLine();
//string[] inputArr = input.Split(new char[] { ' ' });
//int number = Convert.ToInt32(inputArr[0]);  
//int iterations =  Convert.ToInt32(inputArr[1]);

//for (int i =  1; i <= iterations; i++)
//{
//    if (number == 10)
//    {
//        number = 1; break;
//    }
//    else if (number % 10 == 0)
//    {
//        number = number / 10;
     
//    }
//    else if (number % 10 != 0)
//    {
//        number--;
       
//    }
//}
//Console.WriteLine(number);


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