﻿// Напишите программу, которая принимает на вход координаты двух точек и находит  расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7, -5); B (1, -1) -> 21

Console.WriteLine("введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x  второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y  второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);
double result = Math.Sqrt(skobX + skobY);

Console.WriteLine(result);