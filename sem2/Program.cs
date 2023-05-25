//Программа, которая выдаёт случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

// int MaxDigit (int randomNum)
// {
//     int dec = randomNum / 10;
//     int ed = randomNum % 10;
//     if (dec == ed)
//     Console.WriteLine("Число является палиндромом");
//     if (dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 100);

// int result = MaxDigit(num);
// Console.WriteLine($"{num} -> {result}");

// Программа, которая принимает на вход два числа и выводит, является второе число кратным первому. если нет, то показывает остаток от деления

// bool Multiplicity (int num1, int num2)
// {
//     if (num1 % num2 ==0) return true;
//     else return false;
// }
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {Multiplicity(num1, num2)}, remainder = {num1%num2}");

// Программа, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
// bool Multiplicity (int num)
// {
//     if (num % 23 ==0 || num % 7==0) return true;
//     else return false;
// }
// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} -> {Multiplicity(num)}");

// Программа, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

// bool Quad (int num1, int num2)
// {
//    if (num1 * num1 == num2 || num2 * num2 == num1) return true;
//    else return false;
// }
// Console.WriteLine("Input first number");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Quad(number1, number2));
