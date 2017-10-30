using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            var isRunning = true;
            Console.WriteLine(
                "Welcome to the StopWatch App\nThe inputs are as follows: Start, Stop, Duration, Exit");
            try
            {
                do
                {      
                    var input = Console.ReadLine();

                    switch (input)
                    {         
                        case "Start":
                            Console.WriteLine("\nStarting StopWatch\n");
                            stopWatch.Start();
                            break;
                        case "Stop":
                            Console.WriteLine("\nStopping StopWatch\n");
                            stopWatch.Stop();
                            break;                       
                        case "Duration":
                            Console.WriteLine("\nDuration of time was: {0}", stopWatch.Duration());
                            break;
                        case "Exit":
                            Console.WriteLine("\nExiting the StopWatch\n");
                            isRunning = false;
                            break;
                    } 
                } while (isRunning);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }
    }
}
