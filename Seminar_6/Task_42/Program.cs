// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void FindBinNum(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = Convert.ToString(num % 2) + res;
        num = num / 2;
    }
    Console.WriteLine(res);
}

try
{
    Console.WriteLine("Введите целое число:");
    int num = Convert.ToInt32(Console.ReadLine());
    FindBinNum(num);
}

catch
{
    Console.WriteLine("Ошибка ввода, введите целые числовые значения!");
}