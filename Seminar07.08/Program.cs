// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное число {number}");
// int number1 = number % 10;
// int number2 = number / 100;
// Console.WriteLine($"{number2}{number1}");
//Console.WriteLine($"Результат выполнения равен{number2 * 10 + number1}");

// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
// выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 != 0)
// {
//     Console.WriteLine(num1 % num2);
// }

// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
 
//  if (num % 7 == 0 & num % 23 == 0)
//  {
//     Console.WriteLine("Да");
//  }
//  else
//  {
//     Console.WriteLine("Нет");
//  }

// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 | num2 == num1 * num1)
{
    Console.WriteLine("Да");
 }
else
{
    Console.WriteLine("Нет");
}
