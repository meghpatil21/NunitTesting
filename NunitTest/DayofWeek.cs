using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class DayofWeeks
    {
        public static void DayWeek()
        {
            Console.WriteLine("Enter month number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int y0, x, m0, d0;

            y0 = y - (14 - m) / 12;
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;

            switch (d0)
            {
                case 0:
                    { Console.WriteLine("Sunday"); }
                    break;
                case 1:
                    { Console.WriteLine("Monday"); }
                    break;
                case 2:
                    { Console.WriteLine("Tuesday"); }
                    break;
                case 3:
                    { Console.WriteLine("Wednesday"); }
                    break;
                case 4:
                    { Console.WriteLine("Thursday"); }
                    break;
                case 5:
                    { Console.WriteLine("Friday"); }
                    break;
                case 6:
                    { Console.WriteLine("Saturday"); }
                    break;
            }
        }
    }
}
