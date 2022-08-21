// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int storage = number;

while (storage/10 != 0)
{
    sum = sum + (storage % 10);
    storage = storage / 10;
}
Console.WriteLine($"Сумма цифр в числе {number} равна {sum+storage}");