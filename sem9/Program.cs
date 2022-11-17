// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    //Console.Write(n + " ");
    if(n > 1) ShowNums(n -1);
    Console.Write(n + " ");
}

ShowNums(5);
*/

// Задача 2. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
int SumOfDigits(int n)
{
    if(n != 0) return SumOfDigits(n / 10) + n % 10;
    else
    return 0;
}
Console.WriteLine(SumOfDigits(1234));
*/

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumber(int m, int n)
{
    if(n == m)
    {
        Console.Write(n + " ");
    }
    if(n < m)
    {
        ShowNumber(m - 1, n);
        Console.Write(m + " ");
    } 
    if(n > m) 
    {
        ShowNumber(m, n - 1);
        Console.Write(n + " ");
    }
    
}

ShowNumber(1,5);
*/

// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double ShowNumber(double a, double b)
{
    if(b < 0)
    {
        return 1 / a * ShowNumber(a, b +1);
    }
    if(b > 0)
    {
        return a * ShowNumber(a, b - 1);
    } 
    return 1;
}

Console.Write(ShowNumber(2,-3));
*/


