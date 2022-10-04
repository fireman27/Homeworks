// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
int a = 0;

int NumberWithoutSecDig()
{
    a = N / 100 * 10 + N % 10;
    return a;
}

NumberWithoutSecDig();

System.Console.WriteLine($"Если из числа {N} удалить вторую цифру, получится число {a}");
