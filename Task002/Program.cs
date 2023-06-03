// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты точки x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки z2: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine("Расстояние между двумя точками в пространстве равно " + distance);