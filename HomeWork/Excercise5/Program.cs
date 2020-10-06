using System;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var permanent = new PermanentEmployeeFactory();
            var client = new EmployeeClient(permanent);

            Console.WriteLine($"Sick Leave {client.GetSickLeave()}");
            Console.WriteLine($"Paid Leave {client.GetPaidLeave()}");
            Console.WriteLine($"Public Holidays {client.GetPublicHolidays()}");

            Console.ReadLine();
        }
    }
}
