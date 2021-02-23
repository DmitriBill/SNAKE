using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Snake
{
    public class Leader
    {
        public Leader(int score)
        {
            Thread.Sleep(2000);
            Console.Clear(); 
            Console.WriteLine("Введите свой Никнэйм: "); 
            string name = Console.ReadLine(); 
            StreamWriter file=new StreamWriter(@"C:\Users\User\Desktop\Snake\resources\Leader.txt", true); 
            file.WriteLine(name + " - " + score); 
            file.Close(); 
            var fileToOpen = @"C:\Users\User\Desktop\Snake\resources\Leader.txt"; 
            var process = new Process(); 
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true, 
                FileName = fileToOpen 
            };

            process.Start(); 
            process.WaitForExit(); 
        }
    }
}