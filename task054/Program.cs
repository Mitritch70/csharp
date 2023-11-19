/*
Задайте двумерный массив. Напишите программу, которая 
 упорядочит по убыванию элементы каждой строки двумерного массива.
*/

Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SortingRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = j + 1; n < array.GetLength(1); n++)
            {
                if (array[i, n] > array[i, j])
                {
                    int temp = array[i, n];
                    array[i, n] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}
int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
int[,] newArray = SortingRows(array2D);
System.Console.WriteLine();
Print2DArray(newArray);
