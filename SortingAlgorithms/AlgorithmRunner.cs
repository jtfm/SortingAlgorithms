using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class AlgorithmRunner
    {
        public Action Algorithms { get; set; }

        public void RunAlgorithm()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            // Algorithm.Run
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
