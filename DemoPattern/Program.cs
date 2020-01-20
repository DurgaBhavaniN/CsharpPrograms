using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton();
            Singleton s1=Singleton.GetInstance;
            s1.printDetails("Employee");
            // Singleton s2 = new Singleton();
            Singleton s2 = Singleton.GetInstance;
            s2.printDetails("student");
            Console.ReadLine();

        }
    }
}
