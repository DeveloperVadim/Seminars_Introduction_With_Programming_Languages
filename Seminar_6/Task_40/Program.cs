// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

void TriangleCheck(int A, int B, int C)
{
    if (A < B + C & B < C + A & C < A + B) Console.WriteLine("Треугольник с такими сторонами существует ");
    else Console.WriteLine("Треугольник с такими сторонами не существует ");
}

try
{
    Console.WriteLine("Введите сторону A треугольника:");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону B треугольника:");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону C треугольника:");
    int C = Convert.ToInt32(Console.ReadLine());
    TriangleCheck(A, B, C);
}

catch
{
    Console.WriteLine("Ошибка ввода, введите целые числовые значения!");
}
