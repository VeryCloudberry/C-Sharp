// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DRandomArrayRealNumbers(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
//             array[i, j] = Math.Round(array[i, j], 2);
//         }
//     }
//     return array;
// }

// void Print2DArrayDouble(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++) 
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//    }
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input max value of array element ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// Print2DArrayDouble(Create2DRandomArrayRealNumbers(rows, columns, minValue, maxValue));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DArray (int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array [i, j] = new Random().Next(-100, 101);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++) 
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//    }
// }

// int NumberInPosition (int [,] array, int n, int m)
// {
//     if(m > array.GetLength(0) || n > array.GetLength(1)) Console.WriteLine("No such element");
//     return array[m,n];
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);

// Console.WriteLine("Enter row number");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter column number ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The value of element in {m} row and {n} column is {NumberInPosition(myArray, m, n)}");


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2DArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Print2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array element ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);

void ArithmeticMean (int[,] array)
{
    double Average = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double Sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            Sum += array[i,j];  
        }
        Average = Sum / rows;
        Average = Math.Round (Average, 2);
        Console.Write(Average + " ");
    }
}



ArithmeticMean(myArray);





