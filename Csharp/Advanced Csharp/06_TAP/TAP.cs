using System;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced_Csharp._06_TAP
{
    public class TAP // Task - Based Asynchronous 
    {
        private static object _lock = new object();

        private static async Task ProcessBatch1(CancellationToken CancellationToken)
        {
            Console.WriteLine("Batch 1 Thread Id : " + Environment.CurrentManagedThreadId);
            await Task.Delay(500);
            Console.WriteLine("Batch 1 - after await - Thread Id : " + Environment.CurrentManagedThreadId);
            for (int i = 1; i <= 100; i++)
            {
                // cancel
                if (CancellationToken.IsCancellationRequested)
                    return ;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return;
        }

        private static async Task ProcessBatch2(CancellationToken CancellationToken)
        {
            Console.WriteLine("Batch 2 Thread Id : " + Environment.CurrentManagedThreadId);
            await Task.Delay(1);
            Console.WriteLine("Batch 2 - after await - Thread Id : " + Environment.CurrentManagedThreadId);

            for (int i = 101; i <= 200; i++)
            {
                if (CancellationToken.IsCancellationRequested)
                    return ;
                lock (_lock) // like a mutex
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            return ;
        }


        private static async Task ProcessThread1(CancellationToken CancellationToken)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                // cancel
                if (CancellationToken.IsCancellationRequested)
                    return;

                 await Task.Delay(1);

                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return;
        }

        private static async Task ProcessThread2(CancellationToken CancellationToken)
        {

            for (int i = 101; i <= 200; i++)
            {
                if (CancellationToken.IsCancellationRequested)
                    return;

                await Task.Delay(100);

                lock (_lock) // like a mutex
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            return;
        }



        public static async Task TestTAP()
        {
            //var cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;

            //Console.WriteLine("Main Thread Id : " + Environment.CurrentManagedThreadId);

            //Task t1 = ProcessBatch1(token);
            //Task t2 = ProcessBatch2(token);


            //  *********  Second Example  *********



            //var cts = new CancellationTokenSource();

            //CancellationToken token = cts.Token;

            //Task t1 = ProcessThread1(token);
            //Task t2 = ProcessThread2(token);

            //Console.WriteLine("Please Enter your name : ");
            //var name = Console.ReadLine(); // you write in main thread
            //Console.WriteLine($"Welcome {name}");


            // **** now using awit 



            var cts = new CancellationTokenSource();

            CancellationToken token = cts.Token;

            //var t1 = ProcessThread1(token);
            //var t2 = ProcessThread2(token);

            // await Task.WhenAll(t1, t2);  //  block until t1 && t2 finish -run paralelle-

            // await Task.WhenAny(t1, t2);  // li salat ayreja3 lexecution 





            // ***** continuouation  *****


            var t1 = ProcessThread1(token);
            var t2 = ProcessThread2(token);




            Console.WriteLine("Please Enter your name : ");
            var name = Console.ReadLine(); // you write in main thread
            Console.WriteLine($"Welcome {name}");


            Console.ReadKey();
        }


    }
}
