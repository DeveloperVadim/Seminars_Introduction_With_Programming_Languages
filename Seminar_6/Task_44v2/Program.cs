// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = Fibbonichi(num);
PrintArray(newArray);

int[] Fibbonichi(int num)
{

    int[] myArray = new int[num];

    for (int i = 0; i < num; i++)
    {
        if (i == 0) myArray[i] = 0;
        else if (i == 1) myArray[i] = 1;
        else myArray[i] = myArray[i - 1] + myArray[i - 2];
    }
    return myArray;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (int el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}
