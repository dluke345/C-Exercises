using System;
using System.Runtime.InteropServices;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }
        private bool IsStarted { get; set; }

        public StopWatch()
        {
            StartTime = DateTime.MinValue;
            StopTime = DateTime.MinValue;
            IsStarted = false;
        }

        public void Start()
        {
            try
            {
                if (IsStarted)
                {
                    throw new InvalidOperationException("StopWatch is already running.");
                }
                IsStarted = true;
                StartTime = DateTime.Now;
                StopTime = DateTime.MinValue;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }

        }

        public void Stop()
        {
            try
            {
                if (!IsStarted)
                {
                    throw new InvalidOperationException("StopWatch is not running.");
                }
                IsStarted = false;
                StopTime = DateTime.Now;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }

        }

        //Don't need a setter because we will never be setting the duration.
        public TimeSpan Duration()
        {
            if (IsStarted)
            {
                return new TimeSpan();
            }
            return StopTime - StartTime;
        }
    }
}