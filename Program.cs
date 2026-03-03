using System;
using System.Threading.Tasks;

namespace Agent4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Counter Application!");
            Console.WriteLine("==========================================");
            
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
            Console.WriteLine();

            try
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                    await Task.Delay(500); // 500ms delay between numbers
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during counting: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Counting completed successfully!");
            Console.WriteLine("Thank you for using the Number Counter Application.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}