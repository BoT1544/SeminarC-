// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum =0;

    for(int current = 1; current <= num; current++)
        sum += current;  // sum = sum + current; это расшифровка += !
    
    return sum;
}

Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = GetSum(a);
Console.Write($"sum of numbers from 1 to {a} is {s}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int FindSumDigit(int n)
{

    int current =0;

    while(n > 0)
    {
        n /= 10;
        current++;
    }
    return current;
}
Console.Write("Add the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = FindSumDigit(number);
Console.WriteLine($"number of digit is {sumDigit}");
*/


// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


// Задача 4. Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array  = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void showArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);

//доп зачада сделать запрос массива у пользователя
