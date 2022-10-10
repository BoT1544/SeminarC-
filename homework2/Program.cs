// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit(int num)
{
    if(num >= 100 && num <= 1000)
    {
       int ed = num % 100;
       int del = ed / 10;
       return del;
    }
    else
        return 0; 
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = FindSecondDigit(number);
Console.WriteLine($"SecondDigit of {number} is {SecondDigit}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThirdDigit(int num)
{
    //string text = Convert.ToString(FindThirdDigit);
    if(num < 100)
      return 0;
    else
    {
        int del = num % 10;
        return del;
    }
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit = FindThirdDigit(number);
if(ThirdDigit > 0)
    Console.Write($"Tfird digit of {number} is {ThirdDigit}");
else
    Console.Write($"Not find third digit!");
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool week(int num)
{
    if(num < 6 || num > 8) 
        return false;
    else
        return true;
}

Console.WriteLine("it's a holiday?");
Console.Write("Please input day of the week ");
int number = Convert.ToInt32(Console.ReadLine());

bool day = week(number);
Console.Write($"it's a {day}");
*/
