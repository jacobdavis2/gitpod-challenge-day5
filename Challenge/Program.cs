using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

/* Your Challenge: given the following functions:
     1. First, build and run the program to see how long it takes synchronously.
     2. Next, modify any of the given code you like such that you use async/await
        to improve run time.
     3. Finally, build and run again, and observe the difference in speed and
         order of execution.
        
     As a hint, research for yourself when to use async/await and how to achieve
     concurrent processing using said methodology.
*/

namespace Challenge
{
    class Program
    {
        static public void ScrambleEggs()
        {
            Console.WriteLine("Starting the eggs...");
            for (long i = 0; i < 1000000000; ++i) Math.Sqrt(i);
            Console.WriteLine("Eggs are finished!");
        }

        static public void ToastToast()
        {
            Console.WriteLine("Toasting the toast...");
            for (long i = 0; i < 500000000; ++i) Math.Sqrt(i);
            Console.WriteLine("Toast is toasted!");
        }

        static public void PourOrangeJuice()
        {
            Console.WriteLine("Pouring some juice...");
            for (long i = 0; i < 100000000; ++i) Math.Sqrt(i);
            Console.WriteLine("Orange juice poured!");
        }

        // Some code was taken directly from the Microsoft docs here:
        //  https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=netcore-3.1
        static async Task Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            ScrambleEggs();
            ToastToast();
            PourOrangeJuice();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Time it took to cook breakfast: " + elapsedTime + " seconds.");
        }
    }
}
