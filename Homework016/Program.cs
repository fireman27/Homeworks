// Найти расстояние между точками в пространстве 3D
Console.Write("Введите координаты x1: ");
double x1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координаты x2: ");
double x2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координаты y1: ");
double y1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координаты y2: ");
double y2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine() ?? "0");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
