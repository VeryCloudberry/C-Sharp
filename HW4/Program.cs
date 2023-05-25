// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NaturalDegree (int numA, int numB)
// {
//     int res = 1;
//     for(int i = 1; i <= numB; i++)
//     {
//         res *= numA;
//     }
//     return res;
// }

// Console.WriteLine("Input number A");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Natural degree of {num1} -> {NaturalDegree(num1, num2)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumOfDigits (int Num)
// {
//     int sum = 0;
//     while(Num > 0)
//     {
//         sum += Num % 10;
//         Num /= 10;
//     }
//     return sum;
// }
            
// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of digits in {num} -> {SumOfDigits(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateNewArray(int size, int min, int max)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray [i]= new Random().Next(min, max++);
//     }
//     return newArray;
// }

// void PrintArray(int[] newArray)
// {
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i] + ", ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input the size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the minimum value of element");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the maximum value of element");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(size, min, max);

// PrintArray(myArray);

