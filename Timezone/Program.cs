using System;

namespace Timezone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("__________");
            
            } 

        }
    }
}
