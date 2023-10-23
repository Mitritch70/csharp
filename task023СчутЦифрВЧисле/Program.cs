/*
Счет цифр в числе
*/
class Program
{// должен считать цифры
    public static void Main(string[] args)
    {
        int number = 12345679; 
        int countDg=CountDg(number);
 System.Console.WriteLine(countDg); 
    }
    private static int CountDg( int number)
    {
        string stringNumber= number.ToString();
         return stringNumber.Length;
    }
}
