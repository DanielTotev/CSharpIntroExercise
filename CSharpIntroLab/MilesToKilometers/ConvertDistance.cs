namespace MilesToKilometers
{
    using System;

    public class ConvertDistance
    {
        public static void Main()
        {
            double mile = 1.60934;
            double distanceInKilometers = double.Parse(Console.ReadLine());
            double result = distanceInKilometers * mile;
            Console.WriteLine($"{result:f2}");
        }
    }
}
