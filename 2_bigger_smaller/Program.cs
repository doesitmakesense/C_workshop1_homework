﻿// Задача 2: Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int y = int.Parse(Console.ReadLine());

if (x>y)
{
    Console.WriteLine($"Число {x} больше числа {y} ");
}
else 
{
    Console.WriteLine($"Число {y} больше числа {x} ");
}