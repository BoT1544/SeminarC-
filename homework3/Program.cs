// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckPalidrome(int num)
{
int a = num % 100000; 
int b = a / 10000;

int a1 = num % 10000; 
int b1 = a1 / 1000;

int c = num % 10;

int c1 = num % 100;
int d = c1 / 10;

    if(b == c && b1 == d)
        return true;
    else
        return false;
}

Console.Write("Input five digit number ");
int number = Convert.ToInt32(Console.ReadLine());

bool palidrome = CheckPalidrome(number);
Console.Write($"Answer: {palidrome}");

// Console.Write("input ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10000; 
// int b = a / 1000;

// int c = num % 100;
// int d = c / 10;
// Console.Write($"{b} {d}");


// int a = num % 100000; 
// int b = a / 10000;     //находит 1 цифру

// int a1 = num % 10000; 
// int b1 = a1 / 1000;        //Находит 2 цифру

// int c = num % 10;       //находит последнею цифру

// int c1 = num % 100;
// int d = c1 / 10;      //Находит предпоследнию цифру


