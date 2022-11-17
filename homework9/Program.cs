// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    if(n > 0)
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }
}
Console.Write("input number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/


// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumOfDigits(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Sum of numbers between intervals is: {sum}");
        return;
    }
    SumOfDigits(m, n - 1, sum);
}

Console.Write("input interval start: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input interval end: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumOfDigits(m,n,sum);
*/

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if ((n != 0) && (m == 0))
    {   
        return AckermanFunction(n - 1, 1);  
    } 
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.Write("input number m is: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number n is: ");
int n = Convert.ToInt32(Console.ReadLine());
int ackerman =AckermanFunction(m,n);
Console.Write($"Ackerman function if m = {m}, n = {n} is: A(m,n) = {ackerman}");
*/


