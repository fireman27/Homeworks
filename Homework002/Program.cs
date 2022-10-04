Console.Write("Введите номер дня недели: ");
int i = int.Parse(Console.ReadLine() ?? "0");

if (i == 1) 
{
    Console.WriteLine("Понедельник");
}

if (i == 2) 
{
    Console.WriteLine("Вторник");
}

if (i == 3) 
{
    Console.WriteLine("Среда");
}

if (i == 4) 
{
    Console.WriteLine("Четверг");
}

if (i == 5) 
{
    Console.WriteLine("Пятница");
}

if (i == 6) 
{
    Console.WriteLine("Суббота");
}

if (i == 7) 
{
    Console.WriteLine("Воскресенье");
}

if (i >= 8)
{
    Console.WriteLine("Извините, вы ввели не правильный номер!");
    
}
 
