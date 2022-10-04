// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine($"Второй цифрой числа {N} является {N / 10 % 10} ");

System.Console.WriteLine(); 
