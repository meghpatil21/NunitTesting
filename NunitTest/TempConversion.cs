using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class TempConversion
    {
        public static void Conversion()
        {
            Console.WriteLine("Select Conversion:\n 1.Celsius to Fahrenheit:\n 2.Fahrenheit to Celsius:");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Temp Value in Celsius: ");
                        float f=Convert.ToSingle(Console.ReadLine());

                        float result = (f * 9 / 5) + 32;
                        Console.WriteLine($"{f} Celsius = {result} Fahrenheit");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter Temp Value in Fahrenheit: ");
                        float f = Convert.ToSingle(Console.ReadLine());

                        float result = (f - 32) * 5 / 9;
                        Console.WriteLine($"{f} Fahrenheit = {result} Celsius");
                    }
                    break;
                default: Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
