using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CodeQuestion
{
    public class StopWatch
    {

        public Stopwatch GetStopwatch()
        {
            return Stopwatch.StartNew();
        }
        public TimeSpan StopTimer(Stopwatch timer)
        {
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
