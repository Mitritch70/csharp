﻿/*
напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
4->"-4, -3, -2,  -1, 0, 1, 2, 3, 4"
2->"-2, -1, 0, 1, 2"
*/
Console.WriteLine("введите число N");
int N = int.Parse(Console.ReadLine());
for (int i = N * -1; i < N+1; i++)
System.Console.Write(i + " ");