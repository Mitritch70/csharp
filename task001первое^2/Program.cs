/*
ялвляется ли первое число квадратом второго
*/ 
Console.WriteLine("Введите первое число: ");
int userNamber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int userNamber2 = Convert.ToInt32(Console.ReadLine());
int sqNamber2 = userNamber1 * userNamber1;
bool result = userNamber2 == sqNamber2;
Console.WriteLine(result);

