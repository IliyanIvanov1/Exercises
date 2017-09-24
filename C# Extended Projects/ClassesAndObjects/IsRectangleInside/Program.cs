using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsRectangleInside
{
    public class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle rectangle)
        {
            var leftIsValid = rectangle.Left <= Left;
            var topIsValid = rectangle.Top <= Top;
            var rightIsValid = rectangle.Right >= Right;
            var bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var firstRectangle = CreateRectangle();
            var secondRectangle = CreateRectangle();

            var result = firstRectangle.IsInside(secondRectangle);

            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }
        public static Rectangle CreateRectangle()
        {
            var rectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }

    }
}
