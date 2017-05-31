namespace RectangleArea
{
    using System;

    public class CalcRectangleArea
    {
        public  static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = width * height;
            Console.WriteLine($"{result:f2}");
        }
    }
}
