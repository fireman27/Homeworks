// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число от 1 до N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int a = 1;
int comp = 1;
while (a <= N)
{
    comp = comp * a;
    a++;
}
Console.Write($"Произведение чисел от 1 до N равна - {comp}");