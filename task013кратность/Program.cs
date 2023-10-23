/* 
Напишите программу которая на вход будкт принимать два числа, и выводить будет ли второе число кратным первому. Евли второе число не кратное первому то программа будет выводить остаток от деления
34, 5 не кратное остаток 4
16, 4  кратное число
*/

System.Console.WriteLine("ввидите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ввидите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
System.Console.WriteLine("кратное");    
}
else
{
  System.Console.WriteLine("не кратное" + number1 % number2);  
}