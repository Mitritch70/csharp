 /*
 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5

class Program048// не уверен что правильно понял условия задачи :-(
{
    public static void Main(string[] args)
    {
        int m = 3;//задайте размер m
        int n = 3;//задайте размер n
        int[][] arr = new int[3][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[3];
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = i + j;
            }

        }
        PrintArr(arr);
    }
    private static void PrintArr(int[][] arr)
    {
        foreach (var row in arr)
        {
            System.Console.WriteLine($"[{string.Join(" ", row)}]");
        }
    }

}

RD GR, [Чт 26.10.23 10:39]
/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

/*Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

using System;
Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


/*
int[,] GetIndex2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
*/

string[,] GetIndex2DArray(int row, int column)
{
    string[,] array = new string[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] =($"{i} + {j} = {i + j}");
        }
    }
    return array;
}

/*
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
*/

void Print2DStringArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
string[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn);

//Print2DArray(user2DIndexArray);

Print2DStringArray(user2DIndexArray);
