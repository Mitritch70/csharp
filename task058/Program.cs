// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50

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
void MultiplyIfPossible(int[,] oneArr, int[,] twoArr)
{
        if (oneArr.GetLength(1) != twoArr.GetLength(0))
    {
        System.Console.WriteLine("It is impossible to multiply.");
        return;
    }
    int[,] newArray = MatrixMultiplication(oneArr, twoArr);
    Print2DArray(newArray);
}

int[,] MatrixMultiplication(int[,] oneArr, int[,] twoArr)
{

    int[,] newArray = new int[oneArr.GetLength(0), twoArr.GetLength(1)];
    for (int i = 0; i < oneArr.GetLength(0); i++)
    {
        for (int j = 0; j < twoArr.GetLength(1); j++)
        {
            for (int k = 0; k < twoArr.GetLength(1); k++)
            {
                newArray[i,j] += oneArr[i,k] * twoArr [k,j];
            }
        }    

    }
    return newArray;
}

int[,] oneArray2D = new int[2, 2];
int[,] twoArray2D = new int[2, 2];
// int[,] oneArray2D = {
//             { 1, 2 },
//             { 3, 4 },
//         };

// int[,] twoArray2D = {
//             { 5, 6 },
//             { 7, 8 },
//         };
FillArray(oneArray2D);
Print2DArray(oneArray2D);
System.Console.WriteLine();
FillArray(twoArray2D);
Print2DArray(twoArray2D);
System.Console.WriteLine();
MultiplyIfPossible(oneArray2D, twoArray2D);
