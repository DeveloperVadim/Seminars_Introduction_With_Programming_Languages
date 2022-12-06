// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом 
// массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreatArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

void FaindProd(int[] array, int[] array2, int size)
{
    for (int i = 0; i < size / 2; i++)
    {
        array2[i] = array[i] * array[size - 1 - i];
    }
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
int[] arr2 = new int[size / 2];
FaindProd(arr, arr2, size);
PrintArr(arr2);