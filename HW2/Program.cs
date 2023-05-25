// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit (int randomNum)
// {
//     int remainder = randomNum / 10;
//     int seconedN = remainder % 10;
//     return seconedN;
// }
// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 999 || num < 100)
// {
//     Console.WriteLine("Invalid number");
// }
// else    
// {
//     Console.WriteLine($"{num} -> {SecondDigit(num)}");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit (int randomNum)
// {
//     while (randomNum > 999)
//     {
//         randomNum /= 10;
//     }
//     return randomNum % 10;
// }
// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine("the third digit is missing");
// }
// else
// {
//     Console.WriteLine($"{num} -> {ThirdDigit(num)}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool WeekDay (int day)
// {
//     if (day > 5) return true;
//     else return false;
// }
// Console.WriteLine("Input number of week's day (from 1 to 7)");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 7)
// {
//     Console.WriteLine("this day of the week does not exist enter a number from 1 to 7");
// }
// else    
// {
//     Console.WriteLine($"{num} -> {WeekDay(num)}");
// }