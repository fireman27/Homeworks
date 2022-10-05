// Выяснить является ли число чётным
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if ((a % 2) == 0)
{
    Console.Write("Число четное");
}
else 
{
     Console.Write("Число не четное");
}

