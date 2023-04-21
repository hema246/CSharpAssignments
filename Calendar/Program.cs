using System;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month(press 1 for Jan,2 for Feb,3 for March)....");
            int Month = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the  first day week(0=Sunday, 1=Monday..): ");
            int firstDayOfWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("      Calendar  ");
            Console.WriteLine("S   M   Tu   W   T   F   S");

            int numOfDaysInMonth;
            if (Month == 2)
            {
                if (Year % 4 == 0 || Year % 100 != 0)
                {
                    numOfDaysInMonth = 29;
                }
                else
                {
                    numOfDaysInMonth = 28;
                }
            }
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                numOfDaysInMonth = 30;
            }
            else
            {
                numOfDaysInMonth = 31;
            }

            for (int i = 0; i < firstDayOfWeek; i++)
            {
                if (firstDayOfWeek == 7)
                {
                    continue;
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int i = 1; i <= numOfDaysInMonth; i++)
            {
                Console.Write(i);

                if ((firstDayOfWeek + i) % 7 == 0)

                {
                    Console.WriteLine();
                }
            }
        }
    }
}
