// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int N = new Random().Next(10, 99);
Console.WriteLine(N);
int Max = 0;

int MaxDigit()
{
    int DigitOne = N / 10;
    int DigitTwo = N % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}

MaxDigit();
System.Console.WriteLine();
System.Console.WriteLine($"В числе {N} наибольшая цифра {Max}");
System.Console.WriteLine();