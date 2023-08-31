using System;

namespace InsecureCodeExample
{
    class InputValidationExample
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            int number;

            // Lack of Input Validation
            if (int.TryParse(input, out number))
            {
                Console.WriteLine("Parsed Number: " + number);
            }
        }
    }
}
