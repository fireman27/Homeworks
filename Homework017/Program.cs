// Найти кубы чисел от 1 до N
Console.Write("Введите число от 1 до N: ");
double N = double.Parse(Console.ReadLine() ?? "0");
double a = 1;
while (a <= N)
{
    double b = Math.Pow(a,3);
    Console.WriteLine($"a = {a}, куб числа a = {b}");
    a++;
}