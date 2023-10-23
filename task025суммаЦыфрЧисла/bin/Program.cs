/* Напишите программу, которая принимает
  на вход число и выдаёт сумму цифр в числе.
 452 -> 11
 82 -> 10
 9012 -> 12
 */
System.Console.WriteLine("Введите число ");
int userNamber = Convert.ToInt32(Console.ReadLine());

int Summa(int number)
{
    int sum = 0;
    if (number < 0) number = number * -1;

    for (int i = number; i > 0; i = i / 10)
    {
        int remain = i % 10;
        sum = sum + remain;
    }
    return sum;
}
int userResalt = Summa(userNamber);
System.Console.WriteLine(userResalt);
