using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLandingAltitude
{
   public class Program
    {
       public static void Main()
        {
            var array = Console.ReadLine().Split(' ');
            var altitude = int.Parse(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    var command = array[i];
                    if (command == "up")
                    {
                        altitude += int.Parse(array[i + 1]);
                    }
                    else if (command == "down")
                    {
                        altitude -= int.Parse(array[i + 1]);
                    }
                  
                    
                }
            }
            if(altitude<=0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
