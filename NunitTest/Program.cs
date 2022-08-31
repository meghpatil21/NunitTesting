namespace NunitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Select Option:\n 1.Change Return\n 3.Temperature Conversion");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:VendingMachine.NotesReturn();
                    break;
                case 2:DayofWeeks.DayWeek();
                    break;
                case 3: TempConversion.Conversion();
                    break;
                case 4: MonthlyPayment.MonthPay();
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}