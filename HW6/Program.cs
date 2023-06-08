// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }


// int[] UserArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = UserInput($"Input {i} element ");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ", "");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int PositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//         else count += 0;
//     }
//     return count;
// }

// int size = UserInput("Input the number of elements ");
// int[] myArray = UserArray(size);
// PrintArray(myArray);
// Console.WriteLine($"The number of positive elements -> {PositiveNumbers(myArray)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1, k2 - угловые коэффициенты прямых; b1, b2 - пересечения прямых с осью y.


// double UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToInt32(value);
//     return result;
// }

// double k1 = UserInput("Input the slope k1 for the first line (y = k1*x + b1): ");
// double b1 = UserInput("Input the b1 for the first line (y = k1*x + b1): ");
// double k2 = UserInput("Input the slope k2 for the second line (y = k2*x + b2): ");
// double b2 = UserInput("Input the b2 for the second line (y = k2*x + b2): ");

// double coordinateX(double k1, double b1, double k2, double b2)
// {
//     double X = (b2 - b1) / (k1 - k2);
//     return X;
// }

// double coordinateY(double k1, double b1, double k2, double b2)
// {
//     double Y = (k1*b2 - k2*b1) / (k1 - k2);
//     return Y;
// }


// Console.WriteLine($"The cross points of lines is ({coordinateX(k1, b1, k2, b2)};{coordinateY(k1, b1, k2, b2)})");


