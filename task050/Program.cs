 /*Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
*/
// Console.Clear();
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// bool Number(int[,] arr, int num)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (num == arr[i, j]) return true;
//         }
//     }
//     return false;
// }

// int[,] array2D = new int[3, 4];
// FillArray(array2D);
// PrintArray(array2D);
// System.Console.WriteLine("Введите число: ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// bool result = Number(array2D, userNum);
// System.Console.WriteLine((result) ? $"{userNum} -> такое число в массиве есть" : $"{userNum} -> такого числа в массиве нет");


Console.Clear();
int[,] FillArray(int n, int m, int k)
{
    int[,] arr = new int[n, m];
    int num = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = num;
            num = num + k;
        }
    }
    return arr;
}

void PrintArray(int[,] array)
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


void FindPosition(int[,] array, int x, int y)
{
   if(x < array.GetLength(0) && y < array.GetLength(1))
   {
    System.Console.WriteLine($"Такое число есть {array[x, y]}");
   }
   else
   {
   System.Console.WriteLine("Такого числа нету");
   }
}

System.Console.Write("Введите кол-во строк в массиве n = ");
int userRows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов в массиве m = ");
int userColumns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число на которое будет увеливаться каждый элемент массива k = ");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию которое будем искать в массиве: ");
int indexX = Convert.ToInt32(Console.ReadLine());
int indexY = Convert.ToInt32(Console.ReadLine());
int[,] user2DArray = FillArray(userRows, userColumns, userNum);
PrintArray(user2DArray);
FindPosition(user2DArray, indexX, indexY);
