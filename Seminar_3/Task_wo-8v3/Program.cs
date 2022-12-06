// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти (1, 2, 3, 4): ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Console.Write("x > 0, y > 0");
        break;
    case 2:
        Console.Write("x < 0, y > 0");
        break;
    case 3:
        Console.Write("x < 0, y < 0");
        break;
    case 4:
        Console.Write("x > 0, y < 0");
        break;
    default:
        Console.Write("Координатной четверти с таким номером не существует!");
        break;
}