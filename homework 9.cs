// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void ShowNumbers(int N)
// {
//     if (N>0)
//     {
//         System.Console.Write(N + " ");
//         ShowNumbers(N-1);              
//     }
// }

// int Num = UserInput("input your number: ");
// ShowNumbers(Num);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int SumOfNumbers (int M, int N)
// {
//     if(M == N) return 0;
//     else if (M < N) return N + SumOfNumbers(M, N - 1);
//     else return M + SumOfNumbers (N, M - 1);
// }

// int NumM = UserInput("input first number: ");
// int NumN = UserInput("input second number: ");
// Console.WriteLine($"The sum of numbers between {NumM} and {NumN} -> {SumOfNumbers(NumM, NumN)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int Akkerman (int a, int b)
// {
//     if (a == 0) return b + 1;
//     else if ((a != 0) && (b == 0)) return Akkerman(a - 1, 1);
//     else return Akkerman(a - 1, Akkerman(a, b - 1));
// }

// int NumM = UserInput("input first number: ");
// int NumN = UserInput("input second number: ");
// Console.WriteLine($"Ackermann function for numbers {NumM} and {NumN} -> {Akkerman(NumM, NumN)}");

