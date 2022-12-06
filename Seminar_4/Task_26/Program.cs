// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int SumNum(int arg) // переменная функции меняется на нужную при активации
{
    int count = 0;
    while (arg > 0)
    {
        arg = arg / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(num)); // (см.6) вот так