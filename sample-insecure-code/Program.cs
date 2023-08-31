using System;

namespace InsecureCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insecure Coding Practices

            // 1. SQL Injection Vulnerability
            SQLInjectionExample.Run();

            // 2. Hardcoded Password
            HardcodedPasswordExample.Run();

            // 3. Insecure Random Number Generation
            InsecureRandomExample.Run();

            // 4. Lack of Input Validation
            InputValidationExample.Run();

            // 5. Insecure Direct Object Reference
            InsecureDirectObjectReferenceExample.Run();

            // 6. Insecure File Upload
            InsecureFileUploadExample.Run();

            // 7. Insecure Authentication
            InsecureAuthenticationExample.Run();

            // 8. Insecure Session Management
            InsecureSessionManagementExample.Run();

            // 9. Cross-Site Scripting (XSS) Vulnerability
            XSSVulnerabilityExample.Run();

            // 10. Insecure Data Storage
            InsecureDataStorageExample.Run();

            Console.WriteLine("Insecure coding practices examples executed.");
        }
    }
}
