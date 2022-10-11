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

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit = FindThirdDigit(number);
if(ThirdDigit > 0)
    Console.Write($"Tfird digit of {number} is {ThirdDigit}");
else
    Console.Write($"Not find third digit!");