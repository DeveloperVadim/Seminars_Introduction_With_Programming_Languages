// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
double y2 = Convert.ToInt32(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); // извлечение 
// квадратного корня из суммы квадратов 
dist = Math.Round(dist, 2); // округление до 2х знаков
Console.WriteLine(dist);