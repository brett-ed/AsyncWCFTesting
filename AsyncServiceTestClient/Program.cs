using AsyncServiceTestClient.WcfTestService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncServiceTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>(new string[] { "Brett", "JJ", "Brandy", "Zach" });
            //Console.WriteLine("waiting 10 seconds for all assemblies to load");
            //Thread.Sleep(10000);
            Console.WriteLine("Dispatching asynchronous service calls.....");
            DisplayText(list)
                .ContinueWith(t => Console.WriteLine("All calls dispatched, awaiting results....."));

            Console.ReadKey();
        }

        private static async Task DisplayText(List<string> list)
        {
            list.ForEach(async item =>
           {
               try
               {
                   Task<string> task = new DemoServiceClient().GetStringDataAsync(item);
                   if ( task == await Task.WhenAny(task, Task.Delay(9000)))
                   {
                       Console.WriteLine(await task);
                   }
                   else
                       Console.WriteLine("The execution has timed out.");
               }
               catch (Exception e)
               {
                   Console.WriteLine(e.Message);
               }
           });
        }
    }
}
