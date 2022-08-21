// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void FillArray(int[] collection)
{
    for (int i = 0; i < 2; i++)
    {
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }

}

Console.Write("Введите два числа:\n");
int[] Array = new int[2];
int degree = 1;
FillArray(Array);

for (int i=0; i < Array[1]; i++)
    {
    degree = degree * Array[0];
    }
Console.WriteLine($"{Array[0]} в степени {Array[1]} -> {degree}");