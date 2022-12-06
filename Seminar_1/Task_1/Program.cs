// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Ввод  первого числа ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод второго числа ");
int numB = Convert.ToInt32(Console.ReadLine());
int square = numB * numB;
if (square == numA) // проверка квадрата - да
{
    Console.WriteLine("Да ");
}
else //проверка квадрата - нет
{
    Console.WriteLine("Нет ");
}
Console.WriteLine();