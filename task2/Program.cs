﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("1-е число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("2-е число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("3-е число");
int c = int.Parse(Console.ReadLine()!);
int max;
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("Это число больше: " + max);
