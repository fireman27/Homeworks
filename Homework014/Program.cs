﻿// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти оси координат с 1 до 4: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a == 1)
{
    Console.WriteLine("1 четверть, диапазон для возможных координат: x>0 y>0");
}
else if (a == 2)
{
    Console.WriteLine("2 четверть, диапазон для возможных координат: x<0 y>0");
}
else if (a == 3)
{
    Console.WriteLine("3 четверть, диапазон для возможных координат: x<0 y<0");
}
else if (a == 4)
{
    Console.WriteLine("4 четверть, диапазон для возможных координат: x>0 y<0");
}
else if (a > 4)
{
    Console.WriteLine("Введите цифру от 1 до 4-х");
}