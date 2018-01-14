using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTesting
{
    public class StartUp
    {
        public static void Main()
        {
            SportComplexContext context = new SportComplexContext();
            using (context)
            {
                //var worker = context.Workers
                //    .Where(x => x.WorkersID == 2);
                //Console.WriteLine(worker);

                //var currentAthlete = context.Workers
                //    .Where(x=>x.WorkersID==2)
                //    .Select(x=>x.Name)
                //    .FirstOrDefault();
                //Console.WriteLine(currentAthlete);

                //--Insert
                //Club baseball = new Club();
                //baseball.ClubID = 7;
                //baseball.Club_Name = "Baseball";
                //baseball.ClubTrainerID = 4;
                //baseball.Monthly_Fee = "80lv";
                //baseball.Training_Days = "F,Sat,Sun";
                //baseball.Active_Hours = "14:00-16:00";
                //context.Clubs.Add(baseball);
                //context.SaveChanges();

                //Club baseball = context.Clubs.FirstOrDefault(club => club.Club_Name == "Baseball");
                //Athlete athlete = new Athlete { Name = "Hristo", Last_Name = "Nikolov", DepartmentID = 1, PIN = "131231231", ClubID = 7 };
                //baseball.Athletes.Add(athlete);
                //context.SaveChanges();

                //--Remove
                //Club baseball = context.Clubs.FirstOrDefault(cl => cl.Club_Name == "Baseball");
                //context.Athletes.RemoveRange(baseball.Athletes);
                //context.Clubs.Remove(baseball);
                //context.SaveChanges();

                //--Querying
                //IEnumerable<Athlete> athletes = context.Athletes;
                //Console.WriteLine();
                //foreach (var athlete in athletes)
                //{
                //    Console.WriteLine(athlete.Name + " " + athlete.Last_Name);
                //    Console.WriteLine("--" + athlete.Club.Club_Name);
                //    Console.WriteLine("----" + athlete.Club.Worker.Name + " " + athlete.Club.Worker.Last_name);
                //}

                //--Querying

            }
        }
    }
}
