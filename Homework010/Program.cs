// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Дано число 460");
double a = 460;
Console.WriteLine("Введите число");
double b = double.Parse(Console.ReadLine() ?? "0");
double s = 0;

if (a % b == 0) 
{
    Console.Write("веденное вами число "); 
    Console.Write(b);
    Console.WriteLine(" кратно 466");
}
else 
{
    s = a / b;
    Console.Write("веденное вами число не кратно 466, остаток ");
    Console.WriteLine(s);
}
