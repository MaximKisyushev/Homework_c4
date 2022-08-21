// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    for (int i = 0, enterLength = collection.Length; i < enterLength; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    for (int count = 0, printLength = col.Length; count < printLength; count++)
    {
        Console.Write($"{col[count]}\t");
    }
}

int[] array = new int[8];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
