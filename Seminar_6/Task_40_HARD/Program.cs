// задача 40 - HARD необязательная. На вход программы подаются три целых 
// положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения 
// углов треугольника в градусах, является ли он прямоугольным, равнобедренным, 
// равносторонним.

void TriangleCheck(int A, int B, int C)
{
    if (A < B + C & B < C + A & C < A + B)
        Console.WriteLine("Треугольник с такими сторонами существует ");
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


Периметр A+B+C
Высота p=(A+B+C)/2 h=2*(Math.Sqrt((p(p-A)(p-B)(p-C)),2))/на сторону треугольника (A,B,C)
Площадь S=Math.Pow((p(p-A)(p-B)(p-C)),0.5), S=Math.Sqrt((p(p-A)(p-B)(p-C)),2), S=A*h/2
cos