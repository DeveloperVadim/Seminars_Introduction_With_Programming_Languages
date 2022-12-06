// Напишите программу, которая принимает на вход два числа и проверяет, является 
// ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int square1 = a * a;
int square2 = b * b;
if (square1 == b) Console.WriteLine("Первое число a является квадратом второго числа b");
else if (square2 == a) Console.WriteLine("Второе число b является квадратом первого числа a");
else Console.WriteLine("Числа не являются квадратом друг друга");