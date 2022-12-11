// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int num = 0;
int num1 = 1;
int sum = 0;
Console.Write($"{num}, ");

for (int i = 2; i <=N; i++)
{
    sum = num + num1;
    num1=num; // получаем доп единицу
    num=sum;
    Console.Write($"{sum}, ");
}