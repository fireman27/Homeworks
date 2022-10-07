// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine() ?? "0");
if (daynumber > 5 && daynumber < 8)
    {
        Console.WriteLine("Введенный вами день недели - выходной!");
    }
if (daynumber > 0 && daynumber < 6)
{
    Console.WriteLine("Это рабочий день.");
}
if (daynumber > 7)
{
    Console.WriteLine("Вы ввели не правильную цифру!");
}