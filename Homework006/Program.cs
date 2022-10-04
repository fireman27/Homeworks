// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine($"Третьей цифрой числа {N} является {N / 1 % 10} ");

System.Console.WriteLine(); 
