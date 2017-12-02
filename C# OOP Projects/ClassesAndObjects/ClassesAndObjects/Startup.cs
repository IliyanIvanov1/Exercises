

namespace ClassesAndObjects
{
    using System;
    using System.Linq;

    class Startup
    {
        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }

        public static void Main()
        {
            var firstPoint = CreatePoint();
            var secondPoint = CreatePoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        public static Point CreatePoint()
        {
            var point = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            return new Point
            {
                X = point[0],
                Y = point[1]
            };

        }
        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var sqaureY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + sqaureY);

            return result;
        }
    }

}
