//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
    return array;
}

int[] arr = Array();

foreach (var item in arr)
{
    System.Console.Write(item);
}
