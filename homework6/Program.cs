// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void showArray(int[] array)               
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] CreatingAnArrayManually(int size)
{
    int[] array = new int[size];

    for(int i =0; i < size; i++)
    {
        Console.Write("Input number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());     //Логически простое решение, но большое по объёму символов.
        
    }
    return array;
}

int CountNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}


Console.Write("Input how many numbers: ");
int m =Convert.ToInt32(Console.ReadLine());

int[] myarray = CreatingAnArrayManually(m);
Console.Write("numbers is: ");
showArray(myarray);
int result = CountNumbers(myarray);
Console.WriteLine("Numbers greater than 0 is: " + result);
*/

// Задача 1. (решение без использования массива)  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int current = 0;

for(; ;)
{
    while(number > 0)
    {
        current++;
        count++;
        Console.WriteLine("Numbers inputed: " + count);
        Console.WriteLine("Numbers greater than 0 is: " + current);      //Простое в написании, но пришлось поломать голову, прежде чем найти бесконечный цикл ) Я практически уверен, что тут можно было написать более красивый вариант для пользователя
        Console.Write("Input next number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        number = number1;
    }
    count++;
    Console.WriteLine("Numbers inputed: " + count);
    Console.WriteLine("Numbers greater than 0 is: " + current);
    Console.Write("Input next number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    number = number2;
}
*/



// Задача 2.  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
 Tuple<double, double> FindIntersectionsOfLines(double k1, double b1, double k2, double b2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);   //На мой взгляд логичнее было решить задачу без метода, он уж слишком узкопрофильный, но когда упёрся в то что не могу вывести две переменные из метода, захотелось разобратся, как это будет возможно реализовать. Вроде получилось ! )

    return Tuple.Create(x, y);
}

Console.WriteLine("Input two lines:");
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Tuple<double, double> result = FindIntersectionsOfLines(k1, b1, k2, b2);

Console.WriteLine("Point of intersection of two lines: " + result);
*/



