namespace NunitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Select Option:\n 1.Change Return");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:VendingMachine.NotesReturn();
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}