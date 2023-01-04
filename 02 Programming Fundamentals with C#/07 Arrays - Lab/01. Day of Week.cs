using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekday = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekday[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}