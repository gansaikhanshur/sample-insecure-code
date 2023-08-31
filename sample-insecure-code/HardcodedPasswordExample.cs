using System;

namespace InsecureCodeExample
{
    class HardcodedPasswordExample
    {
        public static void Run()
        {
            // Insecure Hardcoded Password
            string password = "mysecretpassword";
            Console.WriteLine("Password: " + password);
        }
    }
}
