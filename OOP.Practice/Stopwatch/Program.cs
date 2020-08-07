using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch1.Start();

            stopwatch2.Start();

            Thread.Sleep(2000);

            stopwatch1.Stop();

            stopwatch2.Stop();

            stopwatch1.Start();

            Thread.Sleep(3000);

            stopwatch1.Stop();

            TimeSpan duration1 = stopwatch1.Duration;

            TimeSpan duration2 = stopwatch2.Duration;

            Console.WriteLine("Stopwatch 1: " + duration1.TotalSeconds);
            Console.WriteLine("Stopwatch 2: " + duration2.TotalSeconds);
        }
    }
}
