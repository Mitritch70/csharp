/*
Задайте прямоугольный двумерный массив. Напишите 
 программу, которая будет находить строку с наименьшей суммой элементов.
*/
Console.Clear();

void FillArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumRows(int[,] array2D)
{
    int[] result = new int[array2D.GetLength(0)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum = sum + array2D[i, j];
        }
        result[i] = sum;
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма строки {i + 1} = {array[i]}");
    }
    Console.WriteLine();
}

void MinSum(int[] array)
{
    int rows = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            rows = i;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов: строка {rows + 1} = {min}");
}

int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
System.Console.WriteLine();
int[] sumArr = SumRows(array2D);
PrintArray(sumArr);
MinSum(sumArr);
