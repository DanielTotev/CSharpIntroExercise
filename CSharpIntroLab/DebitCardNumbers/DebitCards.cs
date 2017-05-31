namespace DebitCardNumbers
{
    using System;

     public class DebitCards
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
        }
    }
}
