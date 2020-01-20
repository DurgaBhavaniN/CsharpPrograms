using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConvertion
{
    class ConvertDemo
    {
        static void Main(String[] args)
        {
            string s = Convert.ToString(true);
           // Console.WriteLine(s);
            short h = Convert.ToInt16("567");
           // Console.WriteLine(h);
            int i = Convert.ToInt32("232");
            //Console.WriteLine(i);
            long l = Convert.ToInt64("23456");
            Console.WriteLine("{0},{1},{2},{3}",s,h,i,l);
           Console.ReadKey();

        }


            
}
}
