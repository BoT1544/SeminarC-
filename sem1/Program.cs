﻿// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Imput a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;
if(n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("no");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Imput a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

if( n < 0)
{
    current = n;
    n = -n;   
}   

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

/*
Console.Write("Imput a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Uncorrect imput");
}
*/