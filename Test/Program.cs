// Эксперименты !


/*
void FindThirdDigit(int num)
{
    if(num < 100)
    {
        int ed = num % 1000;
        int del = ed / 100;
    }
    else
        Console.WriteLine("Not find third digit!");
} 

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = FindThirdDigit(number);
Console.Write($"Second Digit of {number} is {SecondDigit}");
*/

/*
int num =31;

bool(num < 100)
{
    bool true;
}
    bool false;
*/

// if(num < 1000)
//         {
//             int del = num % 10;
//             return del;
//         }
//         else
//         {
//             int a = num / 100;
//             int b = a % 10;
//             return b;
//         }


// int FindThirdDigit(int num)
// {
//     if(num < 100)
//       return 0;
//     else
//     {
//         while(num >= 999)
//         {
//             num = num / 10;
//         }
//             return num % 10;
//     }
// }

// Console.Write("Input three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ThirdDigit = FindThirdDigit(number);
// if(ThirdDigit > 0)
//     Console.Write($"Tfird digit of {number} is {ThirdDigit}");
// else
//     Console.Write($"Not find third digit!");





// Console.Write("input ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10000; 
// int b = a / 1000;

// int c = num % 100;
// int d = c / 10;
// Console.Write($"{b} {d}");





// int a = num % 100000; 
// int b = a / 10000;     //находит 1 цифру

// int a1 = num % 10000; 
// int b1 = a1 / 1000;        //Находит 2 цифру

// int c = num % 10;       //находит последнею цифру

// int c1 = num % 100;
// int d = c1 / 10;      //Находит предпоследнию цифру

/*
double FindDistans3D(double x, double y, double z, double x1, double y1, double z1)
{
    double num = 0;
    //num = Math.Pow((x1 - x) + (y1 - y) + (z1 - z), 2);  //*( x1-x ) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z);
    x = Math.Pow(x1 - x, 2);
    y = Math.Pow(y1 - y, 2);  //num = (x1 - x)*( x1-x ) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z);
    z = Math.Pow(z1 - z, 2);
    num += x + y + z;
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
/*
double[] CreateRandomArray(int size, int minVal, int maxVal) 
{
    double[] array = new double[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(minVal + new Random().NextDouble() * (maxVal - minVal),2);  //"Эта срочка кода работает, но в её коректности есть большие сомнения
    }

    return array;
}

void showArray(double[] array)
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

double[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);

double result = Math.Round(DifferenceMinMax(myArray),2);
Console.WriteLine($"Difference is: {result}");
*/

/*
int DifferenceMinMax(int[] array)
{
  int min = 0;
  int max = 0;
  int dif = 0;

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

int[] myArray = CreateRandomArray(size, min, max);
showArray(myArray);

int result = DifferenceMinMax(myArray);
Console.WriteLine($"Difference is: {result}");
*/
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Console.WriteLine("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
PrintArray(array);

int[,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}


        bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) 
                {
                  return true;
                }
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
