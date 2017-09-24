using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }

            public string Print()
            {
                return $"({X},{Y})";
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var listOfPoints = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = CreatePoint();
                listOfPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < listOfPoints.Count; first++)
            {
                for (int second = first + 1; second < listOfPoints.Count; second++)
                {
                    var firstpoint = listOfPoints[first];
                    var secondpoint = listOfPoints[second];
                    var distance = Distance(firstpoint, secondpoint);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstpoint;
                        secondPointResult = secondpoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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
