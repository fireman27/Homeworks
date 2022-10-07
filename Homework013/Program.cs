// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b*b)
{
    Console.Write("Да, число ");
    Console.Write(a);
    Console.Write(" является квадратом числа ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Нет, число ");
    Console.Write(a);
    Console.Write(" не является квадратом числа ");
    Console.WriteLine(b);
}
if (b == a*a)
{
    Console.Write("Да, число ");
    Console.Write(b);
    Console.Write(" является квадратом числа ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Нет, число ");
    Console.Write(b);
    Console.Write(" не является квадратом числа ");
    Console.WriteLine(a);
}