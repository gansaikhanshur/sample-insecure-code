using System;

namespace InsecureCodeExample
{
    class InsecureDataStorageExample
    {
        public static void Run()
        {
            // Insecure Data Storage
            string secretData = "Sensitive information stored in plain text.";
            // Your SAST tool should flag this as insecure because it stores sensitive data without encryption.
            Console.WriteLine("Secret Data: " + secretData);
        }
    }
}
