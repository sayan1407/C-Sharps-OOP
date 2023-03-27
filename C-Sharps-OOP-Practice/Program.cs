using System;



namespace C_Sharps_OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StopWatch stopWatch = new StopWatch();
                stopWatch.Start();
                stopWatch.Stop();
                Console.WriteLine(stopWatch.TimeDifference.TotalMilliseconds);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
