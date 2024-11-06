namespace Even_Number_Checker_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Even number checker app");

            String choice;
            int entry;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter an integer to check: ");
                entry = int.Parse(Console.ReadLine());
              

                if (entry % 2 == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("This is even.");
                }
                else 
                {
                    Console.WriteLine("This is odd.");
                }

            Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
        }
    }
}
