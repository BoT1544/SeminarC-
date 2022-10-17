// Задача 1.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiates(int num, int deerge)  // num = 2 dergee = 4
{
    int sum = num;
    for(int count = 1; count < deerge; count++)
        sum = sum * num;
    return sum;
}

Console.WriteLine("Input number and deerge");
Console.Write("Please input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input deerge: ");
int b = Convert.ToInt32(Console.ReadLine());

int show = Exponentiates(a, b);
Console.Write($"number {a} to degree {b} is {show}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
        int ed = num % 10;
        sum = sum + ed;
        num = num / 10;     
    }
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int answer = SumDigit(number);
Console.WriteLine($"Sum of digit {number} is {answer}");
*/

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
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
        Console.Write("Input array element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}


Console.WriteLine("Input array");
Console.Write("Array size: ");
int m =Convert.ToInt32(Console.ReadLine());

int[] myarray = CreatingAnArrayManually(m);
Console.Write("array elements is: ");
showArray(myarray);
*/



