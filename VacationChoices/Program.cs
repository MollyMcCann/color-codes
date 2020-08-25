using System;

namespace VacationChoices
{
    [Flags]
    enum Days
    {
        Sunday = 1,
        Monday= 2,
        Tuesday= 4,
        Wednesday=8,
        Thursday=16,
        Friday=32,
        Saturday= 64
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days choices = Days.Tuesday | Days.Thursday | Days.Sunday;
            Console.WriteLine(choices);
        }
    }
}
