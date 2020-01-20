using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{

   sealed class Singleton
    {
        static int count = 0;
        static Singleton Instance=null;//memeory not alloated so object does not exists
        public static Singleton GetInstance
        {
            get
            {//Instance is null memory will be alloted
                if (Instance == null)
                   return new Singleton();
                else
                    return Instance;//existing instance ref returned
            }
        }
        private Singleton()//constructor private
        {
           count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine(s + " is created");
        }

    }
}
