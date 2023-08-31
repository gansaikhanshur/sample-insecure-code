using System;

namespace InsecureCodeExample
{
    class InsecureAuthenticationExample
    {
        public static void Run()
        {
            // Insecure Authentication
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username == "admin" && password == "password")
            {
                Console.WriteLine("Authentication successful.");
            }
            // Your SAST tool should flag this as insecure because it uses hardcoded credentials.
        }
    }
}
