/*
int FindBiggerDigit(int num)
{                              // Два знака амперсанд ( && ) обозначате логическое И. Семинар С# 2 время 24:30.
    int result;

    if(num < 10 || num >= 100) // Два вертикальных слеша ( || ) обозначают логическое ИЛИ. Семинар С# 2 время 24:30.
        return 0;
    else
    {
        int ed = num % 10;
        int dec = num / 10;

        if(ed > dec)
            result = ed;
        else
            result = dec;
    }
    
    return result;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/

// Задача в зале 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int removeSecond(int num)
{
    int ed = num % 10;
    int doc = num /100;
    int result = doc * 10 +ed;
    return result;
}

int number = new Random().Next(100,1000); // Верхние пределы при получении рандомного числа не учитываются в скобках будут числа от 101 до 999 (101 уточнить!).
Console.WriteLine(number);
Console.WriteLine(removeSecond(number));
*/

// Задача в зале 2. Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).
/*
bool del(int num, int num1, int num2)
{
    if(num % num1 ==0 && num % num2 == 0)
    {
        return true;
    }
    return false;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input first del: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second del: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Answer: {del(number,a,b)}");
*/