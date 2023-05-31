// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateNewArray(int size)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void CountEvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count += 1;
//         else count += 0;
//     }
//     Console.WriteLine($"Numbers of even numbers in array -> {count}");
// }

// Console.WriteLine("Input the size of array");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(size);

// PrintArray(myArray);
// CountEvenNumbers(myArray);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateNewArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//        newArray[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void SumOddPositions(int[] array)
// {
//     int Sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0) Sum += array[i];
//         else Sum += 0;
//     }
//     Console.WriteLine($"The sum of the values of elements in odd positions is {Sum}");
// }


// Console.WriteLine("Input the size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(size, minValue, maxValue);

// PrintArray(myArray);
// SumOddPositions(myArray);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateNewArray(int size, double minValue, double maxValue)
// {
//     double[] newArray = new double[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().NextDouble()*(maxValue - minValue) + minValue;
//     }
//     return newArray;
// }

// void PrintArray(double[] array)
// {
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void DifMaxMin(double[] array)
// {
//      double maxValue = array[0];
//      double minValue = array[0];
//      double Dif = 0;
//      for(int i = 0; i < array.Length; i++)
//      {
//         if(array[i] > maxValue) maxValue = array[i];
//         if(array[i] < minValue) minValue = array[i];
//         Dif = maxValue - minValue;
//         Dif = Math.Round(Dif, 2);
//      }
//      Console.WriteLine($"The difference between maximum and minimal values is {Dif}");
// }


// Console.WriteLine("Input the size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input maximum value");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[] myArray = CreateNewArray(size, minValue, maxValue);

// PrintArray(myArray);
// DifMaxMin(myArray);

