// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0"); // опять желтый текст
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b*b)
{
    Console.Write("Да, первое число ");
    Console.Write(a);
    Console.Write(" является квадратом числа ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Нет, первое число ");
    Console.Write(a);
    Console.Write(" не является квадратом числа ");
    Console.WriteLine(b);
}

