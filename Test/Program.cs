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