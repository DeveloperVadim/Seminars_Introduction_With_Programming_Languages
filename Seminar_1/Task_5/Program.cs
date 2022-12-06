// Задача №5. Напишите программу, которая на вход принимает одно число (N), а 
// на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Ввод числа ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num * -1;
if (num < 0)
    while (num <= num2) // от -N до N при N отрицательном
    {
        Console.Write($"{num}");
        num++;
    }
while (num2 <= num) // от -N до N при N положительном
{
    Console.Write($"{num2}");
    num2++;
}
Console.WriteLine();