using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;

        while (run)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please enter your number choice: ");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    journal.Add();
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    journal.Save();
                    break;
                case "4":
                    journal.Load();
                    break;
                case "5":
                    run = false;
                    Console.WriteLine("Thank you for your time. Exiting Journal. Have a wonderful day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
    }
}