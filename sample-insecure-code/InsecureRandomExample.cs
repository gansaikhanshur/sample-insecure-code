using System;

namespace InsecureCodeExample
{
    class InsecureRandomExample
    {
        public static void Run()
        {
            // Insecure Random Number Generation
            Random random = new Random();
            int insecureRandomNumber = random.Next();
            Console.WriteLine("Insecure Random Number: " + insecureRandomNumber);
        }
    }
}
