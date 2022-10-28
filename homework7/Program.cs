// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRamdom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(new Random().Next(minValue,maxValue + 1) + (new Random().NextDouble()), 2);     //Сделал уже по другому не как в предыдущей домашней работе, если не ошибаюсь сейчас записано, по вашей рекомендации )
        }                                                                                                           //Из предыдущей домашней работы: array[i] = Math.Round(minVal + new Random().NextDouble() * (maxVal - minVal),2);
    
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

double[,] myArray = CreateRamdom2dArray();
Show2dArray(myArray);
*/



// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRamdom2dArrayFixSize()
{
    int line = 3;
    int columns = 4;
    int minValue = 1;
    int maxValue = 5;

    int[,] array = new int[line, columns];

    for(int i = 0; i < line; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void CheckElemet(int[,] array)
{
    Console.WriteLine("Input position element");
    Console.Write("Input line: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < array.GetLength(0); i++)
    {        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(columns == j && line == i)
            { 
                Console.Write($"Find elemet is: {array[i,j]}");           
                Environment. Exit(0);                               //Задача не сложная, но поиски метода завершения программы заняло много времени, из-за не совсем коректной формулировки запросов
            }                                                       //Увы не было достаточного времени для изучения решения через string, но обязательно на каникулах попробую решить эту задачку через string )
        }        
    }
    Console.Write($"Not find element on position: {line}, {columns}"); 
}

int[,] myArray = CreateRamdom2dArrayFixSize();
Show2dArray(myArray);
CheckElemet(myArray);
*/



// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRamdom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void showArrayDouble(double[] array)
{
    Console.Write("Average columns is: ");
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double[] Average(int[,] array)
{
    double sum = 0;
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {        
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        result[j] = Math.Round(sum / array.GetLength(0),1);
        sum = 0;
    }
    return result;
}

int[,] myArray = CreateRamdom2dArray();
Show2dArray(myArray);
double[] average = Average(myArray);
Console.WriteLine();
showArrayDouble(average);
*/
