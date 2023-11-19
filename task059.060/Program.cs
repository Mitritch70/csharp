/*
адайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
*/

Console.Clear();


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void MinElement(int[,] array, out int minInRow, out int minInCol)
{
    minInRow = 0;
    minInCol = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                minInRow = i;
                minInCol = j;
                min = array[i, j];
            }
        }
    }
    System.Console.WriteLine($"min = {min} i = {minInRow} j = {minInCol}");
}

int[,] DeletedRowsColumns(int[,] array, int minInRow, int minInCol)
{
    
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newInRow = 0;
    int newInCol = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != minInRow)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minInCol)
                {
                    newArray[newInRow, newInCol] = array[i, j];
                    newInCol++;
                }

            }
            newInRow++;
            newInCol = 0;
        }
    }
    return newArray;
}

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

Print2DArray(array);
System.Console.WriteLine();
MinElement(array, out int minInRow, out int minInCol);
System.Console.WriteLine();
int[,] newArr = DeletedRowsColumns(array, minInRow, minInCol);
Print2DArray(newArr);