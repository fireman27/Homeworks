// Показать четные числа от 1 до N
Console.WriteLine("Здесь появятся четные числа до N. Введите значение конца диапазона N");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 2;
while(i <= N)
{
    Console.WriteLine(i);
    i = i + 2;
} 