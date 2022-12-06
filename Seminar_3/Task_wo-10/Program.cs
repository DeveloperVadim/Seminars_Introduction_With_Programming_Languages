// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите N");
double N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат чисел до N равен:");
for (int i = 1; i <= N; i++)
{
    int sqr = i * i;
    Console.Write($"{sqr} ");
}