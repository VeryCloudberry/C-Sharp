// Task 2. Проверить возможно ли существование треугольника со сторонами a, b и c. 
// Треугольник существует только тогда, когда сумма двух его сторон больше третьей. 

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b >c && a + c > b && b + c > a) return true;
//     return false;
// }

// System.Console.WriteLine("Input A length: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input B length: ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input C length: ");
// int c = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CheckTriangle(a, b, c));

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a, b.

// int[] Fibonachi( int size, int firstNum, int secondNum)
// {
//     int[] array = new int[size];
//     array [0] = firstNum;
//     array [1] = secondNum; m,n
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input first number of array Fibonachi: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input second number of array Fibonachi: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// PrintArray(Fibonachi(size, firstNum, secondNum));

// Задача (зал). Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

int[] ReverseArray(int[] array)
{
    int tmp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = tmp;
    }
    return array;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int[] WishRotate(int[] wishRotate, int size)
// {
//     //int[] wishRotate = new int[size];
//     int box = 0;
//     for (int i = 0; i < size - 1 - i; i++)
//     {
//         box = wishRotate[i];
//         wishRotate[i] = wishRotate[size - 1 - i];
//         wishRotate[size - 1 - i] = box;
//     }
//     return wishRotate;
// }


Console.WriteLine($"input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input minValue");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
int[] RotateArray = ReverseArray(myArray);
PrintArray(RotateArray);