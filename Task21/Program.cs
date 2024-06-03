// Напишите программу, которая принимает на вход координаты двух точек и находит  расстояние между ними в 3D пространстве.

// A (3, 6, 8); B(2, 1, -7) -> 15,84
// A (7, -5, 0); B (1,-1, 9) -> 11,53

Console.WriteLine("введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x  второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y  второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z  второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

Double skobX = Math.Pow(x1 - x2, 2);
Double skobY = Math.Pow(y1 - y2, 2);
Double skobZ = Math.Pow(z1 - z2, 2);
Double result = Math.Sqrt(skobX + skobY + skobZ);

Console.WriteLine(result);