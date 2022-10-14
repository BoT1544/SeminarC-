// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistans3D(double x, double y, double z, double x1, double y1, double z1)
{
    double num = 0;
    x = Math.Pow(x1 - x, 2);   //num = (x1 - x)*( x1-x ) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z);
    y = Math.Pow(y1 - y, 2);   //Выше на мой взгляд более компактный вариант записи. 
    z = Math.Pow(z1 - z, 2);   //Интересно, а какой способ будет занимать меньше места и работать быстрее ?
    num += x + y + z;          //Если пободное будет использовать в крупных проектах.
    num = Math.Sqrt(num);     
    num = Math.Round(num, 2);
    return num;
}

Console.Write("Input coordinate x for point A: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y for point A: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate z for point A: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate x1 for point B: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate y1 for point B: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate z1 for point B: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double distans = FindDistans3D(x, y, z, x1, y1, z1);
Console.WriteLine($"Distance between points A and B is {distans}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubedNumbers(int num)
{
    int current = 1;
    while(current <= num)
    {
        double n = Math.Pow(current, 3);
        Console.Write($"{n} ");
        current++;
    }
}

Console.Write("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubedNumbers(number);
*/