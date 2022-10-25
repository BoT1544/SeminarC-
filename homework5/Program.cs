// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
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
*/
/*
int EvenArrayNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible valie: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible valie: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);

int result = EvenArrayNumbers(myArray);
Console.WriteLine($"Even numbers found in array is: {result}");
*/


// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumNotEvenArray(int[] array)
{
  int sum = 0;

  for(int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }
  return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible valie: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible valie: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);

int result = SumNotEvenArray(myArray);
Console.WriteLine($"Even numbers found in array is: {result}");
*/

// Задача 3.  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomDoubleArray(int size, int minVal, int maxVal) 
{
    double[] array = new double[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(minVal + new Random().NextDouble() * (maxVal - minVal),2);  //"Эта срочка кода работает, но в её коректности есть большие сомнения
    }

    return array;
}

void showArrayDouble(double[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DifferenceMinMax(double[] array)
{
  int min = 0;
  int max = 0;
  double dif = 0;

  for(int i = 1; i < array.Length; i++)
  {
    if(array[i] > array[max])
      max = i;
    if(array[i] < array[min])
      min = i;
  }
  Console.WriteLine($"min: ({array[min]}) max: ({array[max]})");
  dif = array[max] - array[min];
  return dif;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible valie: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible valie: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomDoubleArray(size, min, max);
showArrayDouble(myArray);

double result = Math.Round(DifferenceMinMax(myArray),2);
Console.WriteLine($"Difference is: {result}");
*/



