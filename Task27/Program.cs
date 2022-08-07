// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int numder = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (numder > 0)
{
    int num = numder % 10;
    numder = numder / 10;
    sum = num + sum;
}
Console.WriteLine($"Ответ - {sum}");