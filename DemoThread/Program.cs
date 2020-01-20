using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main started");
            ThreadClass t2= new ThreadClass();
            Thread th = new Thread(t2.countEven);
            Thread th1= new Thread(t2.countOdd);
            th.Priority = ThreadPriority.AboveNormal;
            th1.Priority = ThreadPriority.Highest;
            th.Start();
            th1.Start();
       
            if (!th1.IsAlive) 
                th.Interrupt();
            Console.WriteLine("Main ends");
            Console.ReadLine();

        }
    }
}
