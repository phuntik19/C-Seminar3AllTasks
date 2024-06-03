// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов числе от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.WriteLine("Введи число и будет магия квадратных чисел");
int number = Convert.ToInt32(Console.ReadLine());

for (int i =1; i <= number; i++ )
{
    Console.WriteLine(Math.Pow(i, 2));
}