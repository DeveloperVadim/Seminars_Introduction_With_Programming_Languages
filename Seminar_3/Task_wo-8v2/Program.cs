// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть");
int chet = Convert.ToInt32(Console.ReadLine());

if (chet == 1) Console.WriteLine("x>0,y>0");
else if (chet == 4) Console.WriteLine("x>0,y<0");
else if (chet == 2) Console.WriteLine("x<0,y>0");
else if (chet == 3) Console.WriteLine("x<0,y<0");
else Console.WriteLine("Ошибка! Введите число в диапазоне от 1 до 4.");