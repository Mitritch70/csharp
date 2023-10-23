/*
 Напишите программу, которая задаёт
  массив из 8 элементов и выводит их на экран.
 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 6, 1, 33 -> [6, 1, 33]
 */

Console.Clear();

void FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        System.Console.WriteLine("Введите n: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor=ConsoleColor.Green;//изменить цвет вывода
    System.Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Thread.Sleep(100);
        System.Console.Write(arr[j]);
        if (j < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write($"{arr[arr.Length - 1]}");
    System.Console.Write("]");
    Console.ResetColor();//после вывода вернуть обратно белый цвет
}

System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[userSize];

FillArray(array);
PrintArray(array);

/*
using System;
Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите n: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}
System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(userSize);
PrintArray(userArray);
*/

/* с запросом диапозона и размера массива от пользователя и рандомным методом
Console.Clear();

int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end+1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        System.Console.Write(", ");//[5, 7, 1, 4]
    }
    System.Console.Write("]");
}

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);

*/
