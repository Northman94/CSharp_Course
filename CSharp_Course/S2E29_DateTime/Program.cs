using System;

namespace S2E29_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now1 = DateTime.Now;
            Console.WriteLine(now1.ToString());

            Console.WriteLine($"It's {now1.Date}, {now1.Hour}:{now1.Minute}");

            DateTime t2 = new DateTime(2016, 8, 15);
            //I no time added => midnight 00:00

            DateTime dayAdition = t2.AddDays(1);
            Console.WriteLine(dayAdition);

            TimeSpan ts = now1 - t2; //Same v
            ts = now1.Subtract(t2); // Same ^

            Console.WriteLine(ts.Days);

            // Days vs TotalDays returns double (part of the day)
        }
    }
}