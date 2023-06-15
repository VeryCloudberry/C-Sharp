// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array [i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] BubbleSortedArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLongLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int z = 0; z < array.GetLength(1)-1; z++)
//             {
//                 if(array[i,z] < array[i,z+1])
//                 {            
//                 int tmp =  array[i,z];
//                 array[i,z] = array[i,z+1];
//                 array[i,z+1] = tmp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[,] mySortedArray = BubbleSortedArray(myArray);
// Print2DArray(mySortedArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array [i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] ArrayOfSums(int[,] array)
// {
//     int[] newArray = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int Sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Sum = Sum + array[i,j];
//         }
//         newArray[i] = Sum;
//     }
//     return newArray;
// } 

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

 
// void LineMinSum (int[] array)
// {
//     int MinSum = array[0];
//     int NumOfLine = 0;
//     for(int i = 0; i < array.Length; i++)
//     {   
//         if(array[i] < MinSum)
//         {
//             MinSum = array[i];
//             NumOfLine = i + 1;
//         } 
//     }
//     Console.WriteLine($"The number of line with minimal sum of elements -> {NumOfLine}");
// }
        
// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] SecondArray = ArrayOfSums(myArray);
// PrintArray(SecondArray);
// LineMinSum(SecondArray);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[,] CreateMatrixA (int rowsM, int columnsN, int minValue, int maxValue)
// {
//     int[,] matrixA = new int[rowsM, columnsN];
//     for(int i = 0; i < rowsM; i++)
//     {
//         for(int j = 0; j < columnsN; j++)
//         {
//             matrixA[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return matrixA;
// }

// int[,] CreateMatrixB (int rowsN, int columnsQ, int minValue, int maxValue)
// {
//     int[,] matrixB = new int[rowsN, columnsQ];
//     for(int i = 0; i < rowsN; i++)
//     {
//         for(int j = 0; j < columnsQ; j++)
//         {
//             matrixB [i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return matrixB;
// }

// int[,] MatrixMultiplication (int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1)!= matrixB.GetLength(0))
//     {
//         Console.WriteLine("Matrix multiplication is not possible. The number of columns of the first matrix must be equal to the number of rows of the second matrix");
//     }
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for(int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             matrixC[i,j] = 0;
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 matrixC[i, j] += matrixA[i,k] * matrixB[k,j];
//             }
//         }
//     }
//     return matrixC;
// }

// void Print2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int rowsM = UserInput("Input number of rows of matrix A: "); 
// int columnsN = UserInput("Input number of columns of matrix A ");
// int rowsN = UserInput("Input number of rows of matrix B: ");
// int columnsQ = UserInput("Input number of columns of matrix B ");

// int minValue = UserInput("Input min value of array element "); 
// int maxValue = UserInput("Input max value of array element ");

// int[,] matrixA = CreateMatrixA(rowsM, columnsN, minValue, maxValue);
// Print2DArray(matrixA);
// Console.WriteLine();
// int[,] matrixB = CreateMatrixB(rowsN, columnsQ, minValue, maxValue);
// Print2DArray(matrixB);
// Console.WriteLine();
// int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
// Print2DArray(matrixC);
