using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class MonthlyPayment
    {
        public static void MonthPay()
        {
            int payment;
            int b, t, n, r, xyz, rev;
            Console.WriteLine("Enter Principal Loan Amount: ");
            int P=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Percent Interest: ");
            int R= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No. of Years to pay loan amount: ");
            int Y= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            n=12*Y;
            r = R / 1200;

            xyz = (1 + r);
            
            
            int power = 1;
            int i = 1;
            

           
                for (i = 1; i <= n; i++)
                {
                    power = power * xyz;
                    
                }
            
            rev=-1*power;
            t = (P * R / 1200);
            b = 1 - rev;

            payment = t / b;

            Console.WriteLine("Monthly Payment is: "+payment);

        }
    }
}
