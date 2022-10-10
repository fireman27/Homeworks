// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число от 1 до N: ");
double N = double.Parse(Console.ReadLine() ?? "0");
double a = 1;
while (a <= N)
{
    double b = Math.Pow(a,3);
    a++;
    if (b % 2 == 0)
    Console.WriteLine(b);
}
Console.WriteLine("Кубы чисел заканчивающиеся на четное число.");
