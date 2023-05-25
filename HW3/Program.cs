﻿// Задача 19. Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool Palindrome (int num)
// {
//     int N1 = num / 10000;
//     int N2 = (num / 1000) % 10;
//     int N5 = num % 10;
//     int N4 = (num / 10) % 10;
//     if (N1 == N5 && N2 == N4) return true;
//     else return false;   
// }

// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10000 || num > 99999)
// {
//     Console.WriteLine("Input five-digit number");
// }
// else
// {
//     Console.WriteLine($"{num} -> {Palindrome(num)}");
// }


// Задача 21. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// Console.WriteLine("Input coordinate X of point A");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y of point A");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z of point A");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X of point B");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y of point B");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z of point B");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A ({xa}, {ya}, {za}) & point B ({xb}, {yb}, {zb}) is {FindDistance(xa,ya,za, xb, yb, zb)}");



// Задача 23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube (int num)
// {
//     int count = 1;
//     Console.Write($"{num} -> ");
//     while (count <= num)
//     {
//         Console.Write($"{Math.Pow(count, 3)}, ");
//         count++;
//     }
// }
// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 0) Console.WriteLine("Input a number greater than zero");
// else Cube(num);
