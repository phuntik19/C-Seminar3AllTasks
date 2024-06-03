// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов  числе от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введи число и будет магия  чисел");
int number = Convert.ToInt32(Console.ReadLine());

for (int i =1; i <= number; i++ )
{
    Console.WriteLine(Math.Pow(i, 3));
}