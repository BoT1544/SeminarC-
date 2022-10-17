//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
  int[] array = new int[size];
  
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minVal, maxVal + 1);
  }

  return array;
}

void showArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int SumOfNegatives(int[] array)
{
    int sum =0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);
int result = SumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is " + result);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.


// Задача 3. Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].




//Задача 4. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.













