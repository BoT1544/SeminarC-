// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    int num = 0;

    if(x > 0 && y > 0) num = 1;
    if(x < 0 && y > 0) num = 2;
    if(x < 0 && y < 0) num = 3;
    if(x > 0 && y < 0) num = 4;

    return num;
}

Console.Write("Input x-coorfinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x-coorfinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x,y);
Console.WriteLine($"The point a ({x},{y}) is in {quartNum} quart");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.



// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.



