using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced_Csharp._05_Multitthreading
{
    public class clsMultithreading
    {

        private static object _lock = new object();

        private static  void    ProcessBatch1(object state)
        {
            var CancellationToken = (CancellationToken)state;

            Thread.Sleep(1000); // 1 ms 
            for (int i =1; i <= 1000; i++)
            {
                // cancel
                if (CancellationToken.IsCancellationRequested)
                    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void ProcessBatch2(object state)
        {
            var CancellationToken = (CancellationToken)state;

            Thread.Sleep(1000); // 1 ms 
            for (int i = 1001; i <= 2000; i++)
            {
                if (CancellationToken.IsCancellationRequested)
                    return;
                lock (_lock) // like a mutex
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
        }

        public static void TestMultithreading()
        {
            // ***** using for loop  *****

            // ProcessBatch1();
            // ProcessBatch2();

            // ***** using Threads not  best practice - old - *****

            //var th1 = new  Thread(ProcessBatch1);
            //th1.Priority = ThreadPriority.Highest; // highest periprety -more exec-
            ////th1.IsBackground = true;
            //var th2 = new  Thread(ProcessBatch2);
            //th2.Priority = ThreadPriority.Lowest;
            ////th2.IsBackground = true;

            //th1.Start();
            //th2.Start();




            // ***** using Threads   best practice   - Modern - *****

            var cancelThread = new CancellationTokenSource();

            ThreadPool.QueueUserWorkItem(ProcessBatch1, cancelThread.Token); // by default Is Background
            ThreadPool.QueueUserWorkItem(ProcessBatch2, cancelThread.Token);

            Thread.Sleep(1100); // 1 ms sleep main thread

            cancelThread.Cancel(); //  Cancel the process he cancel the other 2 threads 



            //Console.ReadKey(); // main thread is forground


        }

    }
}

