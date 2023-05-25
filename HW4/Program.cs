// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NaturalDegree (int numA, int numB)
// {
//     int numA = num1;
//     int numB = num2;
//     int res = numA;
//     for(int i = 1; i < numB; i++)
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

int SumOfDigits (int Num)
{
    int sum = 0;
    int dig = 0;
    while(Num > 0)
    {
        dig = Num / 10;
        sum = sum + dig;
    }
    return sum;
}

Console.WriteLine("Input your number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {num} -> {SumOfDigits(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
