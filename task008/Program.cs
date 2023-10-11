/*
напишите программу которая выводит случайные числа из отрезка [10, 99] и выводит наибольшую цифру числа
78 -> 8
12 -> 2
85 -> 8
*/

int mumber = new Random().Next(10,100);
System.Console.Writeline(number);

int first = number /10;
int last = number % 10;
if(first>last);
{
    System.Console.Writeline("наибольшее" + first);
}
else
{
    System.Console.Writeline("наибольшее" + last);
}

