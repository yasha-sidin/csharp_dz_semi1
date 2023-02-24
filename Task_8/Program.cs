// Task_8: напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int range = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"Четные числа в диапозоне от 1 до {range}: ");
while (i < range - 1)
{
    if (i % 2 ==0)
    {
        Console.Write($"{i}, ");
    }
    i += 1;
}
while (i <= range)
{
    if (i % 2 ==0)
    {
        Console.Write($"{i}");
    }
    i += 1;
}