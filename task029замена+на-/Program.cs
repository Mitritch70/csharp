/*
Напишите программу замена элементов массива: положительные элементы замените на 
 соответствующие отрицательные, и наоборот.
 [-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] Result(int[] num)
{
    
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = num[i] * (-1);
    }
    return num;
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
    System.Console.WriteLine();
}

System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArray(userSize);
PrintArray(userArray);
//PrintArray(Result(userArray));
int[] userResult = Result(userArray);
PrintArray(userResult);
