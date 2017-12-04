using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootItDown_Ballistics_
{
    class Program
    {
        static void Main(string[] args)
        {
            var planeCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = planeCoordinates[0];
            var y = planeCoordinates[1];

            var targetedX = 0;
            var targetedY = 0;
            var targetCoordinates = Console.ReadLine().Split(' ');

            for (int i = 0; i < targetCoordinates.Length; i++)
            {
                if (i % 2 == 0)
                {
                    var command = targetCoordinates[i];
                    var coordinates = int.Parse(targetCoordinates[i + 1]);
                    if (command == "right")
                    {
                        targetedX += coordinates;
                    }
                    else if (command == "left")
                    {
                        targetedX -= coordinates;
                    }
                    else if (command == "up")
                    {
                        targetedY += coordinates;
                    }
                    else if (command == "down")
                    {
                        targetedY -= coordinates;
                    }
                }
            }
            Console.WriteLine($"firing at [{targetedX}, {targetedY}]");
            if (x == targetedX && y == targetedY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
