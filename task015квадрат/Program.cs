/*
Напишите программу которая на вход принимает два числа и провряет является ли одно число квадратом другого
5. 25 -> 25 да
8, 9 -> нет
*/

System.Console.WriteLine("ввидите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2 == number1 * number1 || number1 == number2 * number2)
{
 Console.WriteLine("да");   
}
else
{
    Console.WriteLine("нет");
}