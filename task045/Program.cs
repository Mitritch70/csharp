/*
 Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/
Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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
    System.Console.WriteLine();
}
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}



System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArray(userSize);
PrintArray(userArray);
int[] newArray = CopyArray(userArray);
PrintArray(newArray);
