using System;

namespace CoreEF
{
   public class Program
    {
       public static void Main()
        {
            MyDBContext context = new MyDBContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
