// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (N > 100 && N < 999)
{
    int a = (N % 10);
    Console.Write("Третья цифра заданного числа: ");
    Console.WriteLine (a);
}

if (N > 1000 && N< 10000)
{
    int a = ((N / 10) % 10);
    Console.Write("Третья цифра заданного числа:  ");
    Console.WriteLine (a);
}
else 
{
    Console.WriteLine("Введите другое число");
}

if (N < 100)
{
    Console.Write("Число ");
    Console.Write(N); 
    Console.WriteLine(" не имеет третьей цифры");
}