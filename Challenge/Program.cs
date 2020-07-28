using System;
using System.Threading;
using System.Diagnostics;

/* Your Challenge: given the following functions:
     1. First, build and run the program to see how long it takes synchronously.
     2. Next, modify the method headers and the places they are called such that
         the methods run asynchronously.
     3. Finally, build and run again, and observe the difference in speed and
         order of execution.
*/

namespace Challenge
{
    class Program
    {
        static public void ScrambleEggs()
        {
            Console.WriteLine("Starting the eggs...");
            Thread.Sleep(10000);
            Console.WriteLine("Eggs are finished!");
        }

        static public void ToastToast()
        {
            Console.WriteLine("Toasting the toast...");
            Thread.Sleep(5000);
            Console.WriteLine("Toast is toasted!");
        }

        static public void PourOrangeJuice()
        {
            Console.WriteLine("Pouring some juice...");
            Thread.Sleep(1000);
            Console.WriteLine("Orange juice poured!");
        }

        // Some code was taken directly from the Microsoft docs here:
        //  https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=netcore-3.1
        static void Main(string[] args)
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
