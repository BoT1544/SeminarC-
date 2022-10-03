// Задача 1: напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Imput first number: ");
int n1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Imput second number: ");
int n2 = Convert.ToInt32(Console.ReadLine()); 

if(n1 > n2)
{
    Console.WriteLine("Max number: " + n1 + " Min number: " + n2);
}
else
{
    Console.WriteLine("Max number: " + n2 + " Min number: " + n1);
}
*/


// Задача 2: напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Imput first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput three number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    if(n1 > n3)
    {
        Console.WriteLine("Max number: " + n1);
    }
    else
    {
        Console.WriteLine("Max number: " + n3);
    }
}
else
{
    if(n2 > n3)
    {
        Console.WriteLine("Max number: " + n2);
    }
    else
    {
        Console.WriteLine("Max number: " + n3);
    }
}
*/


// Задача 3: напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Ipmut number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine("Yeeees ! :)");
}
else
{
    Console.WriteLine("No :(");
}
*/

// Задача 4: напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Ipmut number ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= N)
{
    if(current % 2 == 0)
Console.Write(current + " ");
current++;
}