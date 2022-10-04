// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");

while(N >= 100)
{
N = N - 100;
} 
while(N >= 10)
{
N = N - 10;
}

Console.Write("Последняя цифра трехзначного числа ");
Console.WriteLine(N);