// Задача №3. Напишите программу, которая будет выдавать название дня недели по 
// заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Ввод числа ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) // проверка 1
{
    Console.WriteLine("Понедельник ");
}
else if (num == 2) //проверка 2
{
    Console.WriteLine("Вторник ");
}
else if (num == 3) //проверка 3
{
    Console.WriteLine("Среда ");
}
else if (num == 4) //проверка 4
{
    Console.WriteLine("Четверг ");
}
else if (num == 5) //проверка 5
{
    Console.WriteLine("Пятница ");
}
else if (num == 6) //проверка 6
{
    Console.WriteLine("Суббота ");
}
else if (num == 7) //проверка 7
{
    Console.WriteLine("Воскресенье ");
}
else //проверка 8
{
    Console.WriteLine("Вы ошиблись");
}
Console.WriteLine();