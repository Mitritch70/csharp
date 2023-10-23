/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("введите число дня недели от 1 до 7:");
int dayNumder = Convert.ToInt32(Console.ReadLine());
if (dayNumder <= 5 && dayNumder > 0)
{
System.Console.WriteLine("Это рабочий день");
}
if (dayNumder == 6 || dayNumder == 7)
{
  System.Console.WriteLine("Ура это выходной!!!!!");  
}
else if (dayNumder < 1 || dayNumder > 7)
{
System.Console.WriteLine("Такого дня недели не существует!");
}

    

