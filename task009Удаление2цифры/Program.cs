/*
Напишите программу, которая выводт случайное трехзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();
int number = new Random().Next(100, 1000);
System.Console.WriteLine("Ввeдите первое число ");
int first = number / 100;
int last = number % 10;

// System.Console.Write(first + "" + last);
System.Console.WriteLine();
int result = first * 10 + last;
System.Console.WriteLine(result);
 