using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();

            ChristmasCountdown();

            GlazerApp.RunExample();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void GetUserNameAndLocation()
        {
            var person = new Person();

            Console.WriteLine("What is your name?");
            person.Name = Console.ReadLine();

            Console.WriteLine("Hi " + person.Name + "! Where are you from?");
            person.Location = Console.ReadLine();

            Console.WriteLine("I have never been to " + person.Location + ". I bet it is nice.");
            
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        private static void ChristmasCountdown()
        {
            DateTime currentDate = DateTime.Today;

            int day = DateTime.Today.Day;
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;

            Console.WriteLine("Today's date is: " + month + "/" + day + "/" + year);

            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);

            TimeSpan diff = christmas - currentDate;

            Console.WriteLine("There are " + diff.Days + " days until Christmas!");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
    }
}
