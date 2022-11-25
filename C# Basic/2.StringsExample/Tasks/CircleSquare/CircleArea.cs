using System;

namespace CircleArea
{
    // Задача на дом «Окружность»
    public class CircleArea
    {
        static void Main(string[] args)
        {
            double radius1 = 3d;
            double circleArea1 = Math.PI * Math.Pow(radius1, 2);
            double circumference1 = 2 * Math.PI * radius1;

            Console.WriteLine($"Circle area with radius {radius1} = {circleArea1}");
            Console.WriteLine($"Circle circumference with radius {radius1} = {circumference1}");

            double circleArea2 = 12;
            double radius2 = Math.Sqrt(circleArea2 / Math.PI);
            Console.WriteLine($"Circle radius with area {circleArea2} = {radius2}");

            double radius3 = 3;
            double circleSectorAngle3 = Math.PI / 2; // 90 degree
            double circleSectorArea3 = (Math.Pow(radius3, 2) * circleSectorAngle3) / 2;
            Console.WriteLine($"Circle sector area with radius {radius3} = {circleSectorArea3}");

            Console.Read();
        }
    }
}