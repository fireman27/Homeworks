// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
while (N != 0)
{
    sum += N % 10;
    N /= 10;
}
Console.Write($"Сумма цифр в числе равна - {sum}");

