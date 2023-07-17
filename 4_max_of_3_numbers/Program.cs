// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int z = int.Parse(Console.ReadLine());

if (x>y&&x>z)
{
    Console.WriteLine($"Число {x} является наибольшим из введенных чисел");
}
else if (y>x&&y>z)
{
    Console.WriteLine($"Число {y} является наибольшим из введенных чисел");
}
else
{
    Console.WriteLine($"Число {z} является наибольшим из введенных чисел");
}
