using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime startTime;
        private bool isStarted = false;
        public TimeSpan Duration { get; private set; }

        public void Start()
        {
            if (isStarted == true)
                throw new InvalidOperationException("Stopwatch already started");

            isStarted = true;
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            isStarted = false;

            var timeElapsed = DateTime.Now - startTime;

            Duration = Duration.Add(timeElapsed);
        }

    }
}
