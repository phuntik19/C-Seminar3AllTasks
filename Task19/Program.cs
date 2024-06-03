// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 - > да
// 12821 - > да 

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int numberB = number / 10000;
int numberA = number % 10;
int numberC = number / 1000 % 10;
int numberD = number % 100 / 10;


if(numberB == numberA && numberC == numberD) 
{
    Console.WriteLine("Это число палиндром");
}

else
{
    Console.WriteLine("Это число не палиндром");
}


