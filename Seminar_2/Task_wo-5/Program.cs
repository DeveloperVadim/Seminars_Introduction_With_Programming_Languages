// Напишите программу, которая принимает на вход число и проверяет, кратно ли
// оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Ввод числа ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA % 7 == 0 && numA % 23 == 0)
    Console.WriteLine("Число кратно 23 и 7");
else
    Console.WriteLine("Не кратно");