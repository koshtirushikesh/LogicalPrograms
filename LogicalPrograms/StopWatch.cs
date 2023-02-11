using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        internal void RunStopWatch() 
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Welcome to StopWatch Program");
            }
            stopwatch.Stop();
           

            Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);

        }
    }
}
