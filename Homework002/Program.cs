﻿// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int i = int.Parse(Console.ReadLine() ?? "0"); // исправил ошибку (желтый текст)

if (i == 1) 
{
    Console.WriteLine("Понедельник");
}

else if (i == 2) 
{
    Console.WriteLine("Вторник");
}

else if (i == 3) 
{
    Console.WriteLine("Среда");
}

else if (i == 4) 
{
    Console.WriteLine("Четверг");
}

else if (i == 5) 
{
    Console.WriteLine("Пятница");
}

else if (i == 6) 
{
    Console.WriteLine("Суббота");
}

else if (i == 7) 
{
    Console.WriteLine("Воскресенье");
}

else if (i >= 8)
{
    Console.WriteLine("Извините, вы ввели не правильный номер!");
    
}
 
