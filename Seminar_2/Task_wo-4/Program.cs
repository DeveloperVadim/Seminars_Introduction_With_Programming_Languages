// Напишите программу, которая будет принимать на вход два числа и выводить, является 
// ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит 
// остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 % num2;
//int num4 = num2 % num1;
if (num1 % num2 == 0) Console.WriteLine("Второе кратно первому числу ");
//else if (num2 % num1 ==0) Console.WriteLine("Второе кратно первому числу ");
else Console.WriteLine($"Числа не кратны, остаток {num3}"); //{num1}/{num2}={num3} {num2}/{num1}={num4}");