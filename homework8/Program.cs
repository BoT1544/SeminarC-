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



// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void Ordering(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int a = 0; a < array.GetLength(1); a++)
            {
                if(array[i,a] < array[i,j])
                {
                    int temp = array[i,a];
                    array[i,a] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRamdom2dArray();
Show2dArray(myArray);
Ordering(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

// Задача 2.  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRamdom2dArrayFixed(int rows, int columns, int minValue, int maxValue)
{
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

int FindMinSumOfRows(int[,] array)
{
    int minsum = 0;
    int row = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minsum += array[0,i];
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row + 1;
   
}

int[,] myArray = CreateRamdom2dArrayFixed(5,3,1,9);
Show2dArray(myArray);
Console.WriteLine();
int answer = FindMinSumOfRows(myArray);
Console.WriteLine("The row with the smallest sum of elements is: " + answer);
*/

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRamdom2dArrayFixed(int rows, int columns, int minValue, int maxValue)
{
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

int[,] ProductOfTwoMatrices(int[,] array1, int[,] array2)
{
    int[,] arrayMulti = new int[array1.GetLength(1), array2.GetLength(0)];

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(0); j++)
        {
            for(int k = 0; k < array2.GetLength(1); k++)
            {
                arrayMulti[i,k] += array1[i,j] * array2[j,k];
            }
        }
    }
    return arrayMulti;
}


int[,] myArray1 = CreateRamdom2dArrayFixed(2,2,1,3);
int[,] myArray2 = CreateRamdom2dArrayFixed(2,2,1,3);
Show2dArray(myArray1);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();
int[,] arrayMulti = ProductOfTwoMatrices(myArray1, myArray2);
Show2dArray(arrayMulti);
*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
bool ArrayOfTwoDigitNumbers(int[,,] array, int digit)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k] == digit)
                {
                    return true;
                }
            }
        }
    }        
    return false;
}

int[,,] CreateRamdom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of ranks: ");
    int ranks = Convert.ToInt32(Console.ReadLine());
    int minValue = 10;
    int maxValue = 99;

    int[,,] array = new int[rows, columns, ranks];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while(k < array.GetLength(2))
            {
                int digit = new Random().Next(minValue, maxValue + 1);
                if(ArrayOfTwoDigitNumbers(array, digit))
                { 
                    continue;                       
                }
                array[i,j,k] = digit;
                k++;        
            }
        }
    
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    int count = 0;
    for(int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine();
        count++;
        Console.WriteLine(count + " rank");
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j,k] + " ");   //Console.Write($"{array[i,j,k]}{(i,j,k)} ");
            }
            Console.WriteLine();
        }
    }   
}

int[,,] array3d = CreateRamdom3dArray();
Show3dArray(array3d);
*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] SpiralArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    int i = 0, j = 0, k = 0, p = 1;

    while(i < rows * columns)
    {
        k++;
        for(j = k - 1; j < columns - k + 1; j++)
        {
            array[k - 1,j] =p ++;
            i++;
        }
        for(j = k; j < rows - k + 1; j++)
        {
            array[j,columns - k] = p++;
            i++;
        } 
        for(j = columns - k - 1; j >= k - 1; j--)
        {
            array[rows - k,j] = p++;
            i++;
        }  
        for(j = rows - k - 1; j >= k; j--)
        {
            array[j,k - 1] = p++;
            i++;
        }   
    }
    return array;
}

int[,] myArray = SpiralArray();
Show2dArray(myArray);
*/












