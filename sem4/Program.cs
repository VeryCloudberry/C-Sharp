// Task 1. Программа, которая принимает на вход число и выдаёт количество цифр в числе

// int DigitCount (int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         count++;
//         num/=10;
//     }
//     return count;
// }

// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Number of digits in {num} -> {DigitCount(num)}");

//Task2. Программа, которая выводит массив из n элементов

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input the size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the minimum value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the maximum value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

//Task3. Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

// int Factorial (int num)
// {
//     int product = 1;
//     int N = num;
//     int count = 1;
//     while(count <= N)
//     {
//         product = product * count;
//         count++;
//     }
//     return product;
// }

// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Factorial of {num} -> {Factorial(num)}");

//Task4. Программа, которая принимает на вход число N и выдаёт сумму чисел от 1 до N
 
// int Summ (int num)
// {
//     int summ = 0;
//     int N = num;
//     int count = 1;
//     while(count <= N)
//     {
//         summ = summ + count;
//         count++;
//     }
//     return summ;
// }

// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of numbers from 1 to {num} -> {Summ(num)}");