// Напишите программу, которая на вход принимает число и выдает его квадрат 
// (число умноженное на само себя). Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Ввод числа ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
//Console.WriteLine("Квадрат введеного числа равен "+square);
Console.WriteLine($"Квадрат введеного числа равен {square}");
if (num > 9 && num < 100) // проверка на двузначное число
{
    Console.WriteLine("Введеное число двузначно ");
}
while (num <= 25) //вывод всех чисел от введеного до 25
{
    Console.Write($"{num} ");
    num++;
}
Console.WriteLine();