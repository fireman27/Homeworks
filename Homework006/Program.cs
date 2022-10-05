// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine()?? "0");

if (N <= 100) 
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else if (N >= 1000) 
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    Console.WriteLine($"Третьей цифрой числа {N} является {N / 1 % 10} ");
    Console.WriteLine(); 
}
