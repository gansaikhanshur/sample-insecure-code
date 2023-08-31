using System;

namespace InsecureCodeExample
{
    class InsecureSessionManagementExample
    {
        public static void Run()
        {
            // Insecure Session Management
            string sessionId = "12345";
            // Your SAST tool should flag this as insecure because it lacks proper session management controls.
            Console.WriteLine("Session ID: " + sessionId);
        }
    }
}
