using System;
using System.Diagnostics;


namespace _14._01
{
    internal class Program
    {


        static void Main()
        {

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "notepad.exe",
            };
            Process process = new Process()
            {
                StartInfo = startInfo,
            };
            process.Start();
            Console.WriteLine("Select mode:\n(1) wait until the end and print exit code\n(2)Kill child process");
            int mode = int.Parse(Console.ReadLine());
            if (mode == 1)
            {
                Console.WriteLine("Waiting for exit");
                process.WaitForExit();
                Console.WriteLine("Child process exit code: " + process.ExitCode);
            }
            else
            {
                Console.WriteLine("Killing child process");
                process.Kill();
            }
        }
    }
}
