using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharps_OOP_Practice
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public string PreviousAction { get; private set; }
        public TimeSpan TimeDifference { get; private set; }

        public StopWatch()
        {
            PreviousAction = "stop";
        }
        public void Start()
        {
            if (PreviousAction == "start")
                throw new InvalidOperationException("Please first stop the watch");
            StartTime = DateTime.Now;
            PreviousAction = "start";
        }
        public void Stop()
        {
            if (PreviousAction == "stop")
                throw new InvalidOperationException("Please first start the watch");
            TimeDifference = DateTime.Now - StartTime;
            PreviousAction = "stop";
        }
    }
}
