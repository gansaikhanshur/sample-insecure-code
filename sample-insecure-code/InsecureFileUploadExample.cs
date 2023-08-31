using System;

namespace InsecureCodeExample
{
    class InsecureFileUploadExample
    {
        public static void Run()
        {
            // Insecure File Upload
            string uploadedFileName = "user-provided-file.exe";
            // Your SAST tool should flag this as insecure because it allows any file to be uploaded.
            Console.WriteLine("Uploaded File: " + uploadedFileName);
        }
    }
}
