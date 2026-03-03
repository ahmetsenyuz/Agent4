using System;

namespace Agent4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isValidInput = false;
            
            while (!isValidInput)
            {
                Console.Write("Enter a number to count to: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out number) && number > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer greater than 0.");
                }
            }
            
            Console.WriteLine($"You entered: {number}");
            Console.WriteLine("Counting to your number:");
            
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}