/*
напищите программу которая показывает сразу кратность 7 и  23
7 -> нет
161 -> да
*/

System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
  System.Console.WriteLine("кратно");  
}
else
{
   System.Console.WriteLine("не кратно"); 
}