using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class VendingMachine
    {
        public static void NotesReturn()
        {
            Console.WriteLine("Change in Rs to be returned by the Vending Machine: ");
            int change=Convert.ToInt32(Console.ReadLine());
            int thousNotes, fiveHundNotes, hundNotes, fiftyNotes, tenNotes, fiveNotes, twoNotes, oneNotes, rem;
            int count = 0;
            while(change!=0)
            {
                if (change>=1000)
                {
                    thousNotes = change / 1000;
                    change = change % 1000;
                    //m = change;
                    count= count + thousNotes;
                    Console.WriteLine(thousNotes + " 1000 notes");
                }

                else if (change>=500)
                {
                    fiveHundNotes = change / 500;
                    change = change % 500;
                    //m = change;
                    count = count + fiveHundNotes;
                    Console.WriteLine(fiveHundNotes + " 500 notes");
                }
                else if (change >= 100)
                {
                    hundNotes = change / 100;
                    change = change % 100;
                    
                    count=count + hundNotes;
                    Console.WriteLine(hundNotes + " 100 notes");
                }
                else if (change >= 50)
                {
                    fiftyNotes = change / 50;
                    change = change % 50;
                   //em = change;
                    count=count+fiftyNotes;
                    Console.WriteLine(fiftyNotes + " 50 notes");
                }
                else if (change >= 10)
                {
                    tenNotes = change / 10;
                    change=change% 10;  
                    //m = change;
                    count=count + tenNotes;
                    Console.WriteLine(tenNotes + " 10 notes");
                }
                else if (change >= 5)
                {
                    fiveNotes = change / 5;
                    change=change% 5;
                    //m = change;
                    count= count + fiveNotes;
                    Console.WriteLine(fiveNotes + " 5 notes");
                }
                else if (change >= 2)
                {
                    twoNotes = change / 2;
                    change=change % 2;
                   //em = change;
                    count = count + twoNotes;
                    Console.WriteLine(twoNotes + " 2 notes");
                }
                else if (change >= 1)
                {
                    oneNotes = change / 1;
                    change=change % 1;
                   //em = change;
                    count = count + oneNotes;
                    Console.WriteLine(oneNotes + " 1 notes");
                }
            }

            Console.WriteLine("Number of minimum notes to be given : " +count);
        }
    }
}
