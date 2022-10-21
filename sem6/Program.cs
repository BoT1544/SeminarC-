// int[] CreateRandomArray() 
// {
//     Console.Write("Input a number of elements: ");
//     int size = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a min possible valie: ");
//     int min = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a max possible valie: ");
//     int max = Convert.ToInt32(Console.ReadLine());
    
//   int[] array = new int[size];
  
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(minVal, maxVal + 1);
//   }

//   return array;
// }

// void showArray(int[] array)
// {
//     for(int i =0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// void ChangeArray(int[] array)
// {
//     for(int i = 0; j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// int[] myArray = CreateRandomArray();
// showArray(myArray);
// ChangeArray(myArray);
// showArray(myArray);