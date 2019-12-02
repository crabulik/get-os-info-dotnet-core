using System;

namespace GetOsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Alt.NET!");
            Console.WriteLine($"I'm running on {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
        }
    }
}
