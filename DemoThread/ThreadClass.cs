using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoThread
{
    class  SyncClass
    {
        public void display(int x)
        {
            for(int i=0;i<100;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadClass
    {
        SyncClass sd = new SyncClass();
        public void countEven()
        {
            Monitor.Enter(this);
            {
                sd.display(10);
                /*for (int i = 0; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                    //if (i == 50)
                    //    Thread.Sleep(3000);
                }*/
            }
            Monitor.Exit(this);
        }
        public void countOdd()
        {
            Monitor.Enter(this);
            {
                sd.display(20);
                /*for (int i = 1; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                }*/
            }

            Monitor.Exit(this);
        }
        }
}
