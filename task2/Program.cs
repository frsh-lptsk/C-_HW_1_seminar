﻿// Задача 2: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Что бы узнать какое число больше, а какое меньше введите первое число и нажмите Enter");
int number1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
int number2 =int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Наибольшее число  " + number1 + ", а наименьшее число  " + number2);
}
else
{
    Console.WriteLine("Наибольшее число  " + number2 + ", а наименьшее число  " + number1);
}