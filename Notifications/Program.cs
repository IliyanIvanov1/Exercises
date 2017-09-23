using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
                string operation = string.Empty;
                string message = string.Empty;
                string operation2 = string.Empty;
                int code=0;
            for (int i = 0; i < numberOfLines; i++)
            {
                string result = Console.ReadLine();

               
                if (result == "success")
                {
                    operation = Console.ReadLine();
                    message = Console.ReadLine();
                    
                }
                else if (result == "error")
                {
                    operation2 = Console.ReadLine();
                    code = int.Parse(Console.ReadLine());
                    
                }
                
            }
                   ShowSuccess(operation, message);
                   ShowError(operation2, code);
        }
        static void ShowSuccess(string operation,string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }
        static void ShowError(string operation, int code)
        {
            string reason = string.Empty;
            if (code < 0)
            {
                reason += "Internal System Failure";
            }
            else if (code > 0)
            {
                reason += "Invalid Client Data";
            }
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
    }

}
