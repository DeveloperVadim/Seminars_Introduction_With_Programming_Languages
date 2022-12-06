// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Ввод трехзначного числа ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) // проверка на трехзначное число
{
    int num2 = num % 10; // остаток от деления на 10
    Console.WriteLine($"{num2}");

    //string str = num.ToString();
    //Console.WriteLine(str[2]); // вывод третьей цифры числа через строку
}
else
{
    Console.WriteLine("Ошибка");
}
Console.WriteLine();