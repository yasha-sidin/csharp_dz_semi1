﻿// Task_4: напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > numberA)
{
    max = numberB;
}

if (numberC > numberB && numberC > numberA)
{
    max = numberC;
}
Console.WriteLine($"max = {max}");