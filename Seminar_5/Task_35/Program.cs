// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите 
// количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreatArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

void FaindNum(int[] array)
{
    int sum_p = 0;
    foreach (int el in array)
    {
        if (el >= 10 && el <= 99)
            sum_p += 1;
    }
    Console.WriteLine($"количество чисел от 10 до 99 в массиве= {sum_p}");
}

void PrintArr(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreatArr(size);
PrintArr(arr);
FaindNum(arr);