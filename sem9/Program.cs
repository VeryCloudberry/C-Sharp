// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int N)
// {
//     if (N>0)
//     {
//         ShowNumbers(N-1);
//         System.Console.Write(N + " ");
//     }
// }

// ShowNumbers(5);

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if(num > 0)
//     {
//         return FindSum(num/10) + num % 10;
//     }
//     else return num;
// }

// System.Console.WriteLine(FindSum(6392));

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void Numbers(int N, int M)
// {
//     if (M < N)
//     {
//         Console.Write(M + " ");
//         Numbers(M+1, N);
//     }
//     else if (M > N)
//     {
//         Console.Write(N + " ");
//         Numbers(M, N + 1);
//     }
//     else
//     {
//         Console.Write(N);
//     }
// }

// Numbers(5, 1);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int Stepen(int a, int b)
// {
//     if (b > 0)
//     {
//         return Stepen(a, b - 1) * a;
//     }
//     else return 1;
// }
// Console.Write(Stepen(2, 5));
