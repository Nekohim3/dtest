using System;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = 0;
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Hello World!{q++}");
            }
        }
    }
    
}
