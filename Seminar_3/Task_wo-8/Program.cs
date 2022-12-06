// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Напишите четверть координат: ");
int point = Convert.ToInt32(Console.ReadLine());

string pointing(int arg1)
{
    string str;
    if (arg1 == 1) str = "x>0, y>0";
    else if (arg1 == 2) str = "x<0, y>0";
    else if (arg1 == 3) str = "x<0, y<0";
    else if (arg1 == 4) str = "x>0, y<0";
    else str = " нет такой четверти";
    return str;
}

Console.WriteLine("В этой четверти могут быть координаты: ");
Console.WriteLine(pointing(point));