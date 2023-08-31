using System;

namespace InsecureCodeExample
{
    class InsecureDirectObjectReferenceExample
    {
        public static void Run()
        {
            int userId = 1;

            // Insecure Direct Object Reference
            string userProfilePath = "C:\\Profiles\\User" + userId + ".txt";
            Console.WriteLine("User Profile Path: " + userProfilePath);
        }
    }
}
